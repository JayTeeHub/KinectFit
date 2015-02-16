namespace KinectFit
{
    partial class KinectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnGetFit = new System.Windows.Forms.Button();
            this.kinectPanel = new System.Windows.Forms.Panel();
            this.btnTest = new System.Windows.Forms.Button();
            this.lblMeasure = new System.Windows.Forms.Label();
            this.txtMeasPart2 = new System.Windows.Forms.TextBox();
            this.txtMeasPart1 = new System.Windows.Forms.TextBox();
            this.txtMeas3 = new System.Windows.Forms.TextBox();
            this.txtMeas2 = new System.Windows.Forms.TextBox();
            this.txtMeas1 = new System.Windows.Forms.TextBox();
            this.lblDistance = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.checkedListBoxParts = new System.Windows.Forms.CheckedListBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.kinectBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.timer7 = new System.Windows.Forms.Timer(this.components);
            this.timer8 = new System.Windows.Forms.Timer(this.components);
            this.kinectPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kinectBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetFit
            // 
            this.btnGetFit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetFit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetFit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetFit.ForeColor = System.Drawing.Color.White;
            this.btnGetFit.Location = new System.Drawing.Point(485, 38);
            this.btnGetFit.Name = "btnGetFit";
            this.btnGetFit.Size = new System.Drawing.Size(171, 62);
            this.btnGetFit.TabIndex = 8;
            this.btnGetFit.Text = "Get your Fit";
            this.btnGetFit.UseVisualStyleBackColor = true;
            this.btnGetFit.Click += new System.EventHandler(this.btnGetFit_Click);
            // 
            // kinectPanel
            // 
            this.kinectPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.kinectPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kinectPanel.Controls.Add(this.btnTest);
            this.kinectPanel.Controls.Add(this.lblMeasure);
            this.kinectPanel.Controls.Add(this.txtMeasPart2);
            this.kinectPanel.Controls.Add(this.txtMeasPart1);
            this.kinectPanel.Controls.Add(this.txtMeas3);
            this.kinectPanel.Controls.Add(this.txtMeas2);
            this.kinectPanel.Controls.Add(this.txtMeas1);
            this.kinectPanel.Controls.Add(this.lblDistance);
            this.kinectPanel.Controls.Add(this.lblMessage);
            this.kinectPanel.Controls.Add(this.checkedListBoxParts);
            this.kinectPanel.Controls.Add(this.textBox7);
            this.kinectPanel.Controls.Add(this.textBox6);
            this.kinectPanel.Controls.Add(this.textBox5);
            this.kinectPanel.Controls.Add(this.textBox4);
            this.kinectPanel.Controls.Add(this.textBox3);
            this.kinectPanel.Controls.Add(this.kinectBox);
            this.kinectPanel.Controls.Add(this.btnGetFit);
            this.kinectPanel.Location = new System.Drawing.Point(12, 12);
            this.kinectPanel.Name = "kinectPanel";
            this.kinectPanel.Size = new System.Drawing.Size(1186, 690);
            this.kinectPanel.TabIndex = 9;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(14, 182);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 28;
            this.btnTest.Text = "Hide";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // lblMeasure
            // 
            this.lblMeasure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMeasure.BackColor = System.Drawing.Color.Transparent;
            this.lblMeasure.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeasure.ForeColor = System.Drawing.Color.White;
            this.lblMeasure.Location = new System.Drawing.Point(981, 109);
            this.lblMeasure.Name = "lblMeasure";
            this.lblMeasure.Size = new System.Drawing.Size(200, 100);
            this.lblMeasure.TabIndex = 27;
            this.lblMeasure.Text = "Test";
            this.lblMeasure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMeasPart2
            // 
            this.txtMeasPart2.Location = new System.Drawing.Point(184, 39);
            this.txtMeasPart2.Name = "txtMeasPart2";
            this.txtMeasPart2.Size = new System.Drawing.Size(140, 20);
            this.txtMeasPart2.TabIndex = 26;
            // 
            // txtMeasPart1
            // 
            this.txtMeasPart1.Location = new System.Drawing.Point(184, 3);
            this.txtMeasPart1.Name = "txtMeasPart1";
            this.txtMeasPart1.Size = new System.Drawing.Size(140, 20);
            this.txtMeasPart1.TabIndex = 25;
            // 
            // txtMeas3
            // 
            this.txtMeas3.Location = new System.Drawing.Point(3, 80);
            this.txtMeas3.Name = "txtMeas3";
            this.txtMeas3.Size = new System.Drawing.Size(140, 20);
            this.txtMeas3.TabIndex = 24;
            // 
            // txtMeas2
            // 
            this.txtMeas2.Location = new System.Drawing.Point(3, 39);
            this.txtMeas2.Name = "txtMeas2";
            this.txtMeas2.Size = new System.Drawing.Size(140, 20);
            this.txtMeas2.TabIndex = 23;
            // 
            // txtMeas1
            // 
            this.txtMeas1.Location = new System.Drawing.Point(3, 3);
            this.txtMeas1.Name = "txtMeas1";
            this.txtMeas1.Size = new System.Drawing.Size(140, 20);
            this.txtMeas1.TabIndex = 22;
            // 
            // lblDistance
            // 
            this.lblDistance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDistance.BackColor = System.Drawing.Color.Transparent;
            this.lblDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistance.ForeColor = System.Drawing.Color.White;
            this.lblDistance.Location = new System.Drawing.Point(981, 0);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(200, 100);
            this.lblDistance.TabIndex = 21;
            this.lblDistance.Text = "Test";
            this.lblDistance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(0, 588);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(1184, 100);
            this.lblMessage.TabIndex = 20;
            this.lblMessage.Text = "Message";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkedListBoxParts
            // 
            this.checkedListBoxParts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.checkedListBoxParts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxParts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.checkedListBoxParts.FormattingEnabled = true;
            this.checkedListBoxParts.Items.AddRange(new object[] {
            "Shoulders",
            "Chest",
            "Hip",
            "Waist",
            "Leg",
            "Reset"});
            this.checkedListBoxParts.Location = new System.Drawing.Point(3, 478);
            this.checkedListBoxParts.Name = "checkedListBoxParts";
            this.checkedListBoxParts.Size = new System.Drawing.Size(120, 90);
            this.checkedListBoxParts.TabIndex = 19;
            this.checkedListBoxParts.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(184, 429);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(140, 20);
            this.textBox7.TabIndex = 17;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(184, 369);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(140, 20);
            this.textBox6.TabIndex = 16;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(184, 307);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(140, 20);
            this.textBox5.TabIndex = 15;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(184, 237);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(140, 20);
            this.textBox4.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(184, 182);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(140, 20);
            this.textBox3.TabIndex = 13;
            // 
            // kinectBox
            // 
            this.kinectBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kinectBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kinectBox.Location = new System.Drawing.Point(466, 270);
            this.kinectBox.Name = "kinectBox";
            this.kinectBox.Size = new System.Drawing.Size(640, 481);
            this.kinectBox.TabIndex = 9;
            this.kinectBox.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // timer6
            // 
            this.timer6.Tick += new System.EventHandler(this.timer6_Tick);
            // 
            // timer7
            // 
            this.timer7.Tick += new System.EventHandler(this.timer7_Tick);
            // 
            // timer8
            // 
            this.timer8.Tick += new System.EventHandler(this.timer8_Tick);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.ClientSize = new System.Drawing.Size(1210, 761);
            this.Controls.Add(this.kinectPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form6";
            this.Text = "Form6";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form6_Load);
            this.kinectPanel.ResumeLayout(false);
            this.kinectPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kinectBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetFit;
        private System.Windows.Forms.Panel kinectPanel;
        private System.Windows.Forms.PictureBox kinectBox;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckedListBox checkedListBoxParts;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtMeasPart2;
        private System.Windows.Forms.TextBox txtMeasPart1;
        private System.Windows.Forms.TextBox txtMeas3;
        private System.Windows.Forms.TextBox txtMeas2;
        private System.Windows.Forms.TextBox txtMeas1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer6;
        private System.Windows.Forms.Timer timer7;
        private System.Windows.Forms.Timer timer8;
        private System.Windows.Forms.Label lblMeasure;
        private System.Windows.Forms.Button btnTest;
    }
}