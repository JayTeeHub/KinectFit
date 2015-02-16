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
    public partial class Form2 : Form
    {
        Form3 frm3;
        ConnectionClass cc;
        public Form2(ConnectionClass _cc)
        {
            InitializeComponent();
            cc = _cc;
            frm3 = new Form3(cc);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Hide Buttons
            btnStart.Visible = !btnStart.Visible;
            btnCancel.Visible = !btnCancel.Visible;

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
                lblInfo1.Text = "KinectFit is ready to start!";
                if (!btnStart.Visible)
                    btnStart.Visible = true;
                if (!btnCancel.Visible)
                    btnCancel.Visible = true;
                
                if (btnStart.Visible && btnCancel.Visible)
                    progressBar1.Visible = false;
                else
                    progressBar1.Visible = true;
            }
            this.Text = e.ProgressPercentage.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!frm3.Visible)
            {
                if (frm3.IsDisposed)
                {
                    frm3 = new Form3(cc);
                    frm3.Show();
                }
                else
                    frm3.Show();
                
                this.Close();
            }
        }
    }
}
