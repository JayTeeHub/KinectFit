using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KinectFit
{
    public partial class Form1 : Form
    {
        Form2 frm2;
        Form11 frm11;
        ConnectionClass cc;
        public Form1()
        {
            InitializeComponent();
            cc = new ConnectionClass();
            frm2 = new Form2(cc);
            frm11 = new Form11(cc);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            welcomePanel.Left = (this.Width - welcomePanel.Width) / 2;
            welcomePanel.Top = (this.Height - welcomePanel.Height) / 2;

            cc.OpenConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!frm2.Visible)
            {
                if (frm2.IsDisposed)
                {
                    frm2 = new Form2(cc);
                    frm2.Show();
                }
                else
                    frm2.Show();
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (!frm11.Visible)
            {
                if (frm11.IsDisposed)
                {
                    frm11 = new Form11(cc);
                    frm11.Show();
                }
                else
                    frm11.Show();
            }
        }

    }
}
