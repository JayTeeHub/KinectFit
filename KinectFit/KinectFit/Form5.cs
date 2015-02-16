using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
namespace KinectFit
{
    public partial class Form5 : Form
    {
        Form6 frm6;
        ConnectionClass cc;
        public Form5(ConnectionClass _cc)
        {
            InitializeComponent();
            cc = _cc;
            frm6 = new Form6(cc);
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // Start the BackgroundWorker.
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                //Wait 50 milliseconds.
                Thread.Sleep(50);
                // Report progress.
                backgroundWorker1.ReportProgress(i);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Change the value of the ProgressBar to the BackgroundWorker progress.
            progressBar1.Value = e.ProgressPercentage;

            if (e.ProgressPercentage.ToString() == "100")
            {
                
                if (!btnStart.Visible)
                    btnStart.Visible = true;
                if (!btnCancel.Visible)
                    btnCancel.Visible = true;

                if (btnStart.Visible && btnCancel.Visible)
                    progressBar1.Visible = false;
                else
                    progressBar1.Visible = true;

                lblInfo2.Text = "Kinect is ready!";
                this.BackColor =  Color.FromArgb(46, 204, 113);
                txtInstructions.BackColor = Color.FromArgb(46, 204, 113);
            }
            this.Text = e.ProgressPercentage.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4(cc);
            frm4.Show();
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!frm6.Visible)
            {
                if (frm6.IsDisposed)
                {
                    frm6 = new Form6(cc);
                    frm6.Show();
                }
                else
                    frm6.Show();

                this.Close();
            }
        }
    }
}
