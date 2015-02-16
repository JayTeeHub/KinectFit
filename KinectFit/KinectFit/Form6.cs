using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Kinect;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace KinectFit
{
    public partial class Form6 : Form
    {
        private KinectSensor _Kinect;
        private readonly Pen inferredBonePen = new Pen(Brushes.Gray, 1);
        private readonly Pen trackedBonePen = new Pen(Brushes.Green, 6);
        private readonly Pen trackedJointBrush = new Pen(Brushes.Red, 1);
        private readonly Pen inferredJointBrush = new Pen(Brushes.Yellow, 1);
        private readonly Pen clippedBrush = new Pen(Brushes.Red, 12);
        private Skeleton[] _FrameSkeletons;
        private ColorImageFormat imageFormat = ColorImageFormat.RgbResolution640x480Fps30;
        private DepthImageFormat depthFormat = DepthImageFormat.Resolution640x480Fps30;
        private Skeleton skeleton;
        private Skeleton skeletonTracked = new Skeleton();
        private Int32 trackingID;
        private Boolean first = true;

        private DepthImagePoint depthLeft;
        private DepthImagePoint depthRight;
        private Pen chestPen;

        private Double measurement = 0;
        private Double totalMeasurement = 0;

        private Boolean isChest;
        private Boolean isShoulder;
        private Boolean isHip;
        private Boolean isWaist;
        private Boolean isLeg;
        private Boolean part1Measured = false;
        private Boolean part2Measured = false;
        private Boolean is2D;
        private String Part;

        private Boolean isReady = false;

        private Double minDistance = 1.25;
        private Double maxDistance = 1.63;
        private Double measureDistance = 1.55;

        Form7 frm7;
        ConnectionClass cc;
        public Form6(ConnectionClass _cc)
        {
            InitializeComponent();
            cc = _cc;
            frm7 = new Form7(cc);

            //Hide all test points when Initialized
            txtMeas1.Visible = false;
            txtMeas2.Visible = false;
            txtMeas3.Visible = false;
            txtMeasPart1.Visible = false;
            txtMeasPart2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            btnGetFit.Visible = false;
            lblDistance.Visible = false;
            lblMeasure.Visible = false;

            
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            cc.getParts();

            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

            kinectPanel.Width = 666;
            kinectPanel.Height = 174;

            kinectPanel.Left = (this.Width - kinectPanel.Width)  / 9;
            kinectPanel.Top = (this.Height - kinectPanel.Height) / 9;
            
            kinectPanel.Width = kinectPanel.Left * 13;
            kinectPanel.Height = kinectPanel.Top * 9;

            kinectBox.Left = (kinectPanel.Width - kinectBox.Width) / 2;
            kinectBox.Top = (kinectPanel.Height - kinectBox.Height) / 2;

            lblMessage.Width = kinectBox.Width;

            /*lblMessage.Left = (kinectBox.Width + 175) / 2;
            lblMessage.Top = (kinectBox.Height + 350) / 2;*/

            textBox3.Text = cc.UserBrand;
            textBox4.Text = cc.UserGender;
            textBox5.Text = cc.UserStyle;
            textBox6.Text = cc.UserPart1;
            textBox7.Text = cc.UserPart2;

            //Set timer interval for setting up the body part
            timer1.Interval += 2000;
            this.timer1.Tick += new EventHandler(timer1_Tick);

            //Set timer interval for delay
            timer2.Interval += 5000;
            this.timer2.Tick += new EventHandler(timer2_Tick);

            //Set timer interval for kicking off the measurement
            timer3.Interval += 2000;
            this.timer3.Tick += new EventHandler(timer3_Tick);

            //Set timer interval for measurement 1
            timer4.Interval += 2000;
            this.timer4.Tick += new EventHandler(timer4_Tick);

            //Set timer interval for measurement 2
            timer5.Interval += 2000;
            this.timer5.Tick += new EventHandler(timer5_Tick);

            //Set timer interval for measurement 3
            timer6.Interval += 2000;
            this.timer6.Tick += new EventHandler(timer6_Tick);

            //Set timer interval for total measurement
            timer7.Interval += 2000;
            this.timer7.Tick += new EventHandler(timer7_Tick);

            //Set timer interval for 
            timer8.Interval += 2000;
            this.timer8.Tick += new EventHandler(timer8_Tick);

            DiscoverKinectSensor();
        }

        private void btnGetFit_Click(object sender, EventArgs e)
        {
            
            
        }

        private void DiscoverKinectSensor()
        {

            KinectSensor.KinectSensors.StatusChanged += KinectSensors_StatusChanged;
            this.Kinect = KinectSensor.KinectSensors
                                      .FirstOrDefault(x => x.Status == KinectStatus.Connected);
        }

        private void KinectSensors_StatusChanged(object sender, StatusChangedEventArgs e)
        {
            switch (e.Status)
            {
                case KinectStatus.Connected:
                    if (this.Kinect == null)
                        this.Kinect = e.Sensor;
                    break;
                case KinectStatus.Disconnected:
                    if (this.Kinect == e.Sensor)
                    {
                        this.Kinect = null;
                        this.Kinect = KinectSensor.KinectSensors
                                      .FirstOrDefault(x => x.Status == KinectStatus.Connected);

                        if (this.Kinect == null)
                        {
                            //Notify the user that the sensor is diconnected
                        }
                    }
                    break;
                //Handle all other statuses according to needs
            }
        }

        public KinectSensor Kinect
        {
            get { return this._Kinect; }
            set
            {
                if (this._Kinect != value)
                {
                    if (this._Kinect != null)
                    {
                        //Unitialize
                        UnitializeKinectSensor(this._Kinect);
                        this._Kinect = null;
                    }
                }

                if (value != null && value.Status == KinectStatus.Connected)
                {
                    //Initialize
                    this._Kinect = value;
                    InitializeKinectSensor(this._Kinect);

                }
            }
        }

        private void InitializeKinectSensor(KinectSensor sensor)
        {
            if (sensor != null)
            {

                sensor.AllFramesReady += Kinect_AllFramesReady;

                sensor.ColorStream.Enable(imageFormat);
                sensor.DepthStream.Enable(depthFormat);

                sensor.SkeletonStream.Enable();
                sensor.SkeletonStream.TrackingMode = SkeletonTrackingMode.Default;

                this._FrameSkeletons = new Skeleton[sensor.SkeletonStream.FrameSkeletonArrayLength];

                sensor.Start();

                if (sensor.ElevationAngle != 5)
                    sensor.ElevationAngle = 5;
            }
        }

        private void UnitializeKinectSensor(KinectSensor sensor)
        {
            if (sensor != null)
            {
                sensor.Stop();
                sensor.AllFramesReady -= Kinect_AllFramesReady;
                sensor.SkeletonStream.Disable();
                this._FrameSkeletons = null;
            }
        }

        private void Kinect_AllFramesReady(object sender, AllFramesReadyEventArgs e)
        {
            ColorImageFrame colorFrame = e.OpenColorImageFrame();
            DepthImageFrame depthFrame = e.OpenDepthImageFrame();


            if (colorFrame == null)
            {
                return;
            }

            Bitmap bmpFrame = ColorImageFrameToBitmap(colorFrame);

            using (SkeletonFrame frame = e.OpenSkeletonFrame())
            {
                if (frame != null)
                {
                    Graphics g = Graphics.FromImage(bmpFrame);
                    JointType[] joints;

                    frame.CopySkeletonDataTo(this._FrameSkeletons);
                    this.skeleton = (from s in this._FrameSkeletons where s.TrackingState == SkeletonTrackingState.Tracked select s).FirstOrDefault();
                    if (this.skeleton == null)
                    {
                        if (this._Kinect.SkeletonStream.AppChoosesSkeletons)
                        {
                            this.first = true;
                            this._Kinect.SkeletonStream.AppChoosesSkeletons = false;
                        }
                        return;
                    }

                    for (int i = 0; i < this._FrameSkeletons.Length; i++)
                    {
                        skeleton = this._FrameSkeletons[i];

                        if (this.skeleton.TrackingState == SkeletonTrackingState.Tracked)
                        {
                            if (this.first)
                            {
                                this.skeletonTracked = this.skeleton;
                                this.trackingID = skeleton.TrackingId;
                                this._Kinect.SkeletonStream.AppChoosesSkeletons = true;
                                this._Kinect.SkeletonStream.ChooseSkeletons(skeleton.TrackingId);
                                this.first = false;
                            }
                            if (this.skeleton.TrackingId == this.trackingID)
                            {
                               
                                // Displays a gradient near the edge of the display where the skeleton is leaving the screen
                                RenderClippedEdges(this.skeleton, g, this.clippedBrush, this.kinectPanel);

                                //Draws the skeleton's head 
                                joints = new[] { JointType.Head, JointType.ShoulderCenter };
                                this.DrawBone(this.skeleton, g, joints, false);

                                //Draw the skeleton's left arm
                                joints = new[] { JointType.ShoulderLeft, JointType.ElbowLeft };
                                this.DrawBone(this.skeleton, g, joints, false);

                                joints = new[] { JointType.ElbowLeft, JointType.WristLeft };
                                this.DrawBone(this.skeleton, g, joints, false);

                                /*joints = new[] { JointType.WristLeft, JointType.HandLeft };
                                this.DrawBone(this.skeleton, g, joints, false);*/

                                //Draws the skeleton's right arm
                                joints = new[] { JointType.ShoulderRight, JointType.ElbowRight };
                                this.DrawBone(this.skeleton, g, joints, false);

                                joints = new[] { JointType.ElbowRight, JointType.WristRight };
                                this.DrawBone(this.skeleton, g, joints, false);

                                /*joints = new[] { JointType.WristRight, JointType.HandRight };
                                this.DrawBone(this.skeleton, g, joints, false);*/

                                if (checkedListBoxParts.SelectedIndex == 5)
                                {
                                    //Draws the skeleton's shoulders
                                    joints = new[] { JointType.ShoulderCenter, JointType.ShoulderLeft };
                                    this.DrawBone(this.skeleton, g, joints, false);

                                    joints = new[] { JointType.ShoulderCenter, JointType.ShoulderRight };
                                    this.DrawBone(this.skeleton, g, joints, false);

                                    joints = new[] { JointType.ShoulderCenter, JointType.Spine };
                                    this.DrawBone(this.skeleton, g, joints, false);

                                    //Draws the skeleton's hip
                                    joints = new[] { JointType.Spine, JointType.HipCenter };
                                    this.DrawBone(this.skeleton, g, joints, false);

                                    joints = new[] { JointType.HipCenter, JointType.HipLeft };
                                    this.DrawBone(this.skeleton, g, joints, false);

                                    joints = new[] { JointType.HipCenter, JointType.HipRight };
                                    this.DrawBone(this.skeleton, g, joints, false);
                                }

                                if (checkedListBoxParts.SelectedIndex >= 0 && checkedListBoxParts.SelectedIndex != 5)
                                {
                                    if (this.isShoulder || this.isChest || this.isWaist)
                                    {
                                        //Draws the skeleton's shoulders for measure
                                        joints = new[] { JointType.ShoulderCenter, JointType.ShoulderLeft };
                                        this.DrawBone(this.skeleton, g, joints, true);

                                        joints = new[] { JointType.ShoulderCenter, JointType.ShoulderRight };
                                        this.DrawBone(this.skeleton, g, joints, true);

                                        joints = new[] { JointType.ShoulderCenter, JointType.Spine };
                                        this.DrawBone(this.skeleton, g, joints, false);

                                        //Draws the skeleton's hip
                                        joints = new[] { JointType.Spine, JointType.HipCenter };
                                        this.DrawBone(this.skeleton, g, joints, false);

                                        joints = new[] { JointType.HipCenter, JointType.HipLeft };
                                        this.DrawBone(this.skeleton, g, joints, false);

                                        joints = new[] { JointType.HipCenter, JointType.HipRight };
                                        this.DrawBone(this.skeleton, g, joints, false);
                                    }
                                    else if (this.isHip)
                                    {
                                        //Draws the skeleton's hip for measure
                                        joints = new[] { JointType.Spine, JointType.HipCenter };
                                        this.DrawBone(this.skeleton, g, joints, false);

                                        joints = new[] { JointType.HipCenter, JointType.HipLeft };
                                        this.DrawBone(this.skeleton, g, joints, true);

                                        joints = new[] { JointType.HipCenter, JointType.HipRight };
                                        this.DrawBone(this.skeleton, g, joints, true);

                                        //Draws the skeleton's shoulders
                                        joints = new[] { JointType.ShoulderCenter, JointType.ShoulderLeft };
                                        this.DrawBone(this.skeleton, g, joints, false);

                                        joints = new[] { JointType.ShoulderCenter, JointType.ShoulderRight };
                                        this.DrawBone(this.skeleton, g, joints, false);

                                        joints = new[] { JointType.ShoulderCenter, JointType.Spine };
                                        this.DrawBone(this.skeleton, g, joints, false);
                                    }
                                }
                                if (checkedListBoxParts.SelectedIndex <= -1)
                                {
                                    //Draws the skeleton's shoulders
                                    joints = new[] { JointType.ShoulderCenter, JointType.ShoulderLeft };
                                    this.DrawBone(this.skeleton, g, joints, false);

                                    joints = new[] { JointType.ShoulderCenter, JointType.ShoulderRight };
                                    this.DrawBone(this.skeleton, g, joints, false);

                                    joints = new[] { JointType.ShoulderCenter, JointType.Spine };
                                    this.DrawBone(this.skeleton, g, joints, false);

                                    //Draws the skeleton's hip
                                    joints = new[] { JointType.Spine, JointType.HipCenter };
                                    this.DrawBone(this.skeleton, g, joints, false);

                                    joints = new[] { JointType.HipCenter, JointType.HipLeft };
                                    this.DrawBone(this.skeleton, g, joints, false);

                                    joints = new[] { JointType.HipCenter, JointType.HipRight };
                                    this.DrawBone(this.skeleton, g, joints, false);
                                   
                                }

                                // Render Joints
                                foreach (Joint joint in skeleton.Joints)
                                {

                                    Pen drawBrush = null;
                                    if (joint.TrackingState == JointTrackingState.Tracked)
                                    {
                                        drawBrush = this.trackedJointBrush;
                                    }
                                    else if (joint.TrackingState == JointTrackingState.Inferred)
                                    {
                                        drawBrush = this.inferredJointBrush;
                                    }

                                    if (drawBrush != null)
                                    {
                                        Size s = new Size(5, 5);
                                        Point p;
                                        if (joint.JointType == JointType.ShoulderLeft)
                                        {
                                            p = this.SkeletonPointToScreen(joint.Position, true);
                                            this.SkeletonPointToScreen(joint.Position, false);
                                        }
                                        else if (joint.JointType == JointType.ShoulderRight)
                                        {
                                            //this.move = 10;
                                            p = this.SkeletonPointToScreen(joint.Position, true);
                                            this.SkeletonPointToScreen(joint.Position, false);
                                        }
                                        else
                                            p = this.SkeletonPointToScreen(joint.Position, false);

                                        //this._SkeletonPointToScreen(joint.Position);
                                        g.DrawEllipse(drawBrush, new RectangleF(p, s));
                                    }
                                    if (joint.JointType == JointType.Spine)
                                    {
                                        lblDistance.Text = joint.Position.Z.ToString();
                                        if (joint.Position.Z < this.minDistance || joint.Position.Z > this.maxDistance)
                                        {
                                            if (joint.Position.Z < this.minDistance)
                                            {
                                                if(!isReady)
                                                    lblMessage.Text = "Please move away from the Kinect";
                                                
                                            }
                                            else if (joint.Position.Z > this.maxDistance)
                                            {
                                                if(!isReady)
                                                    lblMessage.Text = "Please move closer to the Kinect";
                                                
                                            }
                                        }
                                        if (joint.Position.Z >= this.measureDistance && joint.Position.Z <= this.maxDistance)
                                        {
                                            if (!isReady)
                                            {
                                                lblMessage.Text = "Perfect! please stand still!";
                                                isReady = true;
                                                timer1.Start();
                                            }
                                        }
                                    }

                                }
                                if (this.isShoulder || this.isChest || this.isWaist)
                                    this.measurement = GetDistance(this.skeleton, "ShoulderChestWaist");
                                else if (this.isHip)
                                    this.measurement = GetDistance(this.skeleton, "Hip");
                                else if (this.isLeg)
                                {

                                }
                                lblMeasure.Text = this.measurement.ToString();
                            }
                        }
                    }
                }
            }
            kinectBox.Image = bmpFrame;

        }

        private void DrawBone(Skeleton skeleton, Graphics g, JointType[] joints, Boolean isTest)
        {
            Joint joint0 = skeleton.Joints[joints[0]];
            Joint joint1 = skeleton.Joints[joints[1]];

            // If we can't find either of these joints, exit
            if (joint0.TrackingState == JointTrackingState.NotTracked || joint1.TrackingState == JointTrackingState.NotTracked)
            {
                return;
            }

            // Don't draw if both points are inferred
            if (joint0.TrackingState == JointTrackingState.Inferred && joint1.TrackingState == JointTrackingState.Inferred)
            {
                return;
            }

            // We assume all drawn bones are inferred unless BOTH joints are tracked
            Pen drawPen = this.inferredBonePen;

            if (joint0.TrackingState == JointTrackingState.Tracked && joint1.TrackingState == JointTrackingState.Tracked)
            {
                if (isTest)
                    drawPen = this.chestPen;
                else
                    drawPen = this.trackedBonePen;

            }

            g.DrawLine(drawPen, this.SkeletonPointToScreen(joint0.Position, isTest), this.SkeletonPointToScreen(joint1.Position, isTest));

        }

        /// <summary>
        /// Maps a SkeletonPoint to lie within our render space and converts to Point
        /// </summary>
        /// <param name="skelpoint">point to map</param>
        /// <returns>mapped point</returns>
        private Point SkeletonPointToScreen(SkeletonPoint skelpoint, Boolean isTest)
        {
            // Convert point to depth space.  
            // We are not using depth directly, but we do want the points in our 640x480 output resolution.
            DepthImagePoint depthPoint = this._Kinect.CoordinateMapper.MapSkeletonPointToDepthPoint(skelpoint, DepthImageFormat.Resolution640x480Fps30);
            depthPoint.X += 10;
            if (isTest)
            {
                if (this.isChest)
                {
                    depthPoint.Y += 30;
                }
                if (this.isWaist)
                {
                    depthPoint.Y += 90;
                }
            }

            return new Point(depthPoint.X, depthPoint.Y);
        }

        private void _SkeletonPointToScreen(SkeletonPoint skelpoint)
        {
            // Convert point to depth space.  
            // We are not using depth directly, but we do want the points in our 640x480 output resolution.
            DepthImagePoint depthPoint = this._Kinect.CoordinateMapper.MapSkeletonPointToDepthPoint(skelpoint, DepthImageFormat.Resolution640x480Fps30);

        }

        private static Bitmap ColorImageFrameToBitmap(ColorImageFrame colorFrame)
        {
            byte[] pixelBuffer = new byte[colorFrame.PixelDataLength];
            colorFrame.CopyPixelDataTo(pixelBuffer);

            Bitmap bitmapFrame = new Bitmap(colorFrame.Width, colorFrame.Height, PixelFormat.Format32bppRgb);
            BitmapData bitmapData = bitmapFrame.LockBits(new Rectangle(0, 0, colorFrame.Width, colorFrame.Height), ImageLockMode.WriteOnly, bitmapFrame.PixelFormat);

            IntPtr intPointer = bitmapData.Scan0;
            Marshal.Copy(pixelBuffer, 0, intPointer, colorFrame.PixelDataLength);

            bitmapFrame.UnlockBits(bitmapData);

            return bitmapFrame;
        }

        /// <summary>
        /// Draws indicators to show which edges are clipping skeleton data
        /// </summary>
        /// <param name="skeleton">skeleton to draw clipping information for</param>
        /// <param name="drawingContext">drawing context to draw to</param>
        private static void RenderClippedEdges(Skeleton skeleton, Graphics g, Pen clippedBrush, Panel kinectBox)
        {
            /*if (skeleton.ClippedEdges.HasFlag(FrameEdges.Bottom))
            {
                g.DrawLine(clippedBrush, kinectBox.Left, kinectBox.Bottom, kinectBox.Right, kinectBox.Bottom);
            }*/

            if (skeleton.ClippedEdges.HasFlag(FrameEdges.Top))
            {
                g.DrawLine(clippedBrush, kinectBox.Left - 112, kinectBox.Top - 92, kinectBox.Right, kinectBox.Top - 92);
            }

            if (skeleton.ClippedEdges.HasFlag(FrameEdges.Left))
            {
                g.DrawLine(clippedBrush, kinectBox.Left-110, kinectBox.Top-100, kinectBox.Left-110, kinectBox.Bottom);
            }

            if (skeleton.ClippedEdges.HasFlag(FrameEdges.Right))
            {
                g.DrawLine(clippedBrush, kinectBox.Right+100, kinectBox.Top-100, kinectBox.Right+100, kinectBox.Bottom);
            }
        }

        private double GetDistance(Skeleton skel, String type)
        {
            switch (type)
            {
                case "ShoulderChestWaist":
                    return Math.Sqrt(Math.Pow((skel.Joints[JointType.ShoulderLeft].Position.X - skel.Joints[JointType.ShoulderRight].Position.X), 2) +
                        Math.Pow((skel.Joints[JointType.ShoulderLeft].Position.Y - skel.Joints[JointType.ShoulderRight].Position.Y), 2) +
                        Math.Pow((skel.Joints[JointType.ShoulderLeft].Position.Z - skel.Joints[JointType.ShoulderRight].Position.Z), 2));
                case "Hip":
                    return Math.Sqrt(Math.Pow((skel.Joints[JointType.HipLeft].Position.X - skel.Joints[JointType.HipRight].Position.X), 2) +
                        Math.Pow((skel.Joints[JointType.HipLeft].Position.Y - skel.Joints[JointType.HipRight].Position.Y), 2) +
                        Math.Pow((skel.Joints[JointType.HipLeft].Position.Z - skel.Joints[JointType.HipRight].Position.Z), 2));
                default:
                    return 0;
            }
        }

        private double _GetDistance()
        {
            return Math.Sqrt(Math.Pow((this.depthLeft.X - this.depthRight.X), 2) +
                   Math.Pow((this.depthLeft.Y - this.depthRight.Y), 2));
        }

       
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBoxParts.SelectedIndex != -1)
            {
                if (checkedListBoxParts.SelectedItem.ToString() == "Shoulders")
                {
                    this.chestPen = new Pen(Brushes.Red, 6);
                    this.isHip = false;
                    this.isChest = false;
                    this.isWaist = false;
                    this.isShoulder = true;
                }
                else if (checkedListBoxParts.SelectedItem.ToString() == "Chest")
                {
                    this.chestPen = new Pen(Brushes.Red, 6);
                    this.isHip = false;
                    this.isShoulder = false;
                    this.isWaist = false;
                    this.isChest = true;

                    if (cc.UserBrand.ToLower() == "zara")
                        this.is2D = true;
                    else
                        this.is2D = false;
                }
                else if (checkedListBoxParts.SelectedItem.ToString() == "Hip")
                {
                    this.chestPen = new Pen(Brushes.Red, 6);
                    this.isChest = false;
                    this.isShoulder = false;
                    this.isWaist = false;
                    this.isHip = true;
                }
                else if (checkedListBoxParts.SelectedItem.ToString() == "Waist")
                {
                    this.chestPen = new Pen(Brushes.Red, 6);
                    this.isChest = false;
                    this.isShoulder = false;
                    this.isHip = false;
                    this.isWaist = true;

                    if (cc.UserBrand == "Zara")
                        this.is2D = true;
                    else
                        this.is2D = false;
                }
                else if (checkedListBoxParts.SelectedItem.ToString() == "Leg")
                {
                    this.chestPen = new Pen(Brushes.Red, 6);
                    this.isChest = false;
                    this.isShoulder = false;
                    this.isHip = false;
                    this.isWaist = false;
                    this.isLeg = true;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.timer1.Enabled)
            {
                txtMeas1.Clear();
                txtMeas2.Clear();
                txtMeas3.Clear();

                if (cc.UserStyle.ToLower() == "shirt")
                {
                    if (this._Kinect.ElevationAngle != 5)
                    {
                        this._Kinect.ElevationAngle = 5;
                    }
                }

                if (this.part1Measured && this.part2Measured)
                {
                    this.part1Measured = false;
                    this.part2Measured = false;
                    txtMeasPart1.Clear();
                    txtMeasPart2.Clear();
                }

                if (cc.UserBrand.ToLower() == "zara" && cc.UserGender.ToLower() == "male" && cc.UserStyle.ToLower() == "shirt")
                {
                    if (!this.part1Measured)
                    {
                        this.Part = "Shoulders";
                        lblMessage.Text = "Stand straight, place your palms on your tighs. Measurement of shoulders will start soon. Red body part indicates measurement has started";
                    }
                    else if (this.part1Measured && !this.part2Measured)
                    {
                        this.Part = "Chest";
                        lblMessage.Text = "Stand straight but not tense with your arms at side. Measurement of chest will start soon. Red body part indicates measurement has started";
                    }
                }
                else if (cc.UserBrand == "H&M" && cc.UserGender.ToLower() == "male" && cc.UserStyle.ToLower() == "shirt")
                {
                    if (!this.part1Measured)
                    {
                        this.Part = "Waist";
                        lblMessage.Text = "Stand straight but not tense with your arms at side. Measurement of waist will start soon. Red body part indicates measurement has started";
                    }
                    else if (this.part1Measured && !this.part2Measured)
                    {
                        this.Part = "Chest";
                        lblMessage.Text = "Stand straight but not tense with your arms at side. Measurement of chest will start soon. Red body part indicates measurement has started";
                    }
                }
                else if (cc.UserBrand.ToLower() == "gap" && cc.UserGender.ToLower() == "male" && cc.UserStyle.ToLower() == "shirt")
                {
                    if (!this.part1Measured)
                    {
                        this.Part = "Waist";
                        lblMessage.Text = "Stand straight but not tense with your arms at side. Measurement of waist will start soon. Red body part indicates measurement has started";
                    }
                    else if (this.part1Measured && !this.part2Measured)
                    {
                        this.Part = "Chest";
                        lblMessage.Text = "Stand straight but not tense with your arms at side. Measurement of chest will start soon. Red body part indicates measurement has started";
                    }
                }
                else if (cc.UserBrand.ToLower() == "hugo boss" && cc.UserGender.ToLower() == "male" && cc.UserStyle.ToLower() == "shirt")
                {
                    if (!this.part1Measured)
                    {
                        this.Part = "Chest";
                        lblMessage.Text = "Stand straight but not tense with your arms at side. Measurement of chest will start soon. Red body part indicates measurement has started";
                    }
                    else if (this.part1Measured && !this.part2Measured)
                    {
                        this.Part = "Waist";
                        lblMessage.Text = "Stand straight but not tense with your arms at side. Measurement of waist will start soon. Red body part indicates measurement has started";
                    }
                }
                else if (cc.UserBrand.ToLower() == "urban outfitters" && cc.UserGender.ToLower() == "male" && cc.UserStyle.ToLower() == "shirt")
                {
                    if (!this.part1Measured)
                    {
                        this.Part = "Waist";
                        lblMessage.Text = "Stand straight but not tense with your arms at side. Measurement of waist will start soon. Red body part indicates measurement has started";
                    }
                    else if (this.part1Measured && !this.part2Measured)
                    {
                        this.Part = "Chest";
                        lblMessage.Text = "Stand straight but not tense with your arms at side. Measurement of chest will start soon. Red body part indicates measurement has started";
                    }
                }
                this.timer1.Enabled = false;
                this.timer2.Start();
            }

        }

        //Delay timer
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (timer2.Enabled)
            {
                timer2.Enabled = false;
                timer3.Start();
            }
        }

        //Tell Kinect which body part to measure
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (timer3.Enabled)
            {
                for (int i = 0; i < checkedListBoxParts.Items.Count; i++)
                {
                    if (checkedListBoxParts.Items[i].ToString() == this.Part)
                    {
                        checkedListBoxParts.SetSelected(i, true);
                    }
                }
                timer3.Enabled = false;
                timer4.Start();
            }
        }

        //Make first measurement
        private void timer4_Tick(object sender, EventArgs e)
        {
            if (timer4.Enabled)
            {
                if (txtMeas1.Text == "")
                {
                    txtMeas1.Text = this.measurement.ToString();
                }
                timer4.Enabled = false;
                timer5.Start();
            }
        }

        //Make second measurement
        private void timer5_Tick(object sender, EventArgs e)
        {
            if (timer5.Enabled)
            {
                if (txtMeas2.Text == "")
                {
                    txtMeas2.Text = this.measurement.ToString();
                }

                timer5.Enabled = false;
                timer6.Start();
            }
        }

        //Make third measurement
        private void timer6_Tick(object sender, EventArgs e)
        {
            if (timer6.Enabled)
            {
                if (txtMeas3.Text == "")
                {
                    txtMeas3.Text = this.measurement.ToString();
                }

                timer6.Enabled = false;
                timer7.Start();
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            if (timer7.Enabled)
            {
                List<Double> avgMeasurement = new List<Double>();
                avgMeasurement.Add(Convert.ToDouble(txtMeas1.Text));
                avgMeasurement.Add(Convert.ToDouble(txtMeas2.Text));
                avgMeasurement.Add(Convert.ToDouble(txtMeas3.Text));
                avgMeasurement.ToArray();
                this.totalMeasurement = avgMeasurement.Average();
                if (this.isShoulder)
                    this.totalMeasurement += 0.10;
                if (this.isChest && !is2D)
                {
                    this.totalMeasurement += 0.10;
                    this.totalMeasurement *= 2;
                    this.totalMeasurement += 0.07;
                }
                else if (this.isChest && is2D)
                {
                    this.totalMeasurement += 0.10;
                    this.totalMeasurement += 0.05;
                }
                if (this.isHip)
                {
                    this.totalMeasurement *= 3;
                    this.totalMeasurement += 0.07;
                }
                if (this.isWaist && !is2D)
                {
                    this.totalMeasurement += 0.10;
                    this.totalMeasurement *= 2;
                }
                else if (this.isWaist && is2D)
                {
                    this.totalMeasurement += 0.10;
                }
                if (this.isLeg)
                {

                }
                this.totalMeasurement *= 100;//Convert to cm
                this.totalMeasurement = Math.Round(this.totalMeasurement);

                timer7.Enabled = false;
                timer8.Start();
            }
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            if (timer8.Enabled)
            {
                if (!this.part1Measured)
                {
                    if (txtMeasPart2.Text == "")
                    {
                        this.part1Measured = true;
                        txtMeasPart1.Text = this.totalMeasurement.ToString();
                    }
                }
                else if (this.part1Measured && !this.part2Measured)
                {
                    if (txtMeasPart2.Text == "")
                    {
                        this.part2Measured = true;
                        txtMeasPart2.Text = this.totalMeasurement.ToString();
                    }
                }
                this.timer8.Enabled = false;
                if (this.part1Measured && this.part2Measured)
                {
                    //Measurements finished
                    //Tell user
                    lblMessage.Text = "Measurement is done!";
                    //Stop Kinect
                    this._Kinect.Stop();
                    //Move onto next form
                    cc.Measurements[0] = Convert.ToInt32(txtMeasPart1.Text);
                    cc.Measurements[1] = Convert.ToInt32(txtMeasPart2.Text);
                    cc.getSize();

                    if (!frm7.Visible)
                    {
                        if (frm7.IsDisposed)
                        {
                            frm7 = new Form7(cc);
                            frm7.Show();
                        }
                        else
                            frm7.Show();

                        this.Close();
                    }
                }
                else
                {
                    checkedListBoxParts.SetSelected(5, false);
                    isReady = false;
                }
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            //Toggle all test points when Initialized
            txtMeas1.Visible = !txtMeas1.Visible;
            txtMeas2.Visible = !txtMeas2.Visible;
            txtMeas3.Visible = !txtMeas3.Visible;
            txtMeasPart1.Visible = !txtMeasPart1.Visible;
            txtMeasPart2.Visible = !txtMeasPart2.Visible;
            textBox3.Visible = !textBox3.Visible;
            textBox4.Visible = !textBox4.Visible;
            textBox5.Visible = !textBox5.Visible;
            textBox6.Visible = !textBox6.Visible;
            textBox7.Visible = !textBox7.Visible;
            lblDistance.Visible = !lblDistance.Visible;
            lblMeasure.Visible = !lblMeasure.Visible;
        }
    }
}
