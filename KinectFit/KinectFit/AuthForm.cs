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
    public partial class AuthForm : Form
    {
        Form12 frm12;
        ConnectionClass cc;
        public AuthForm(ConnectionClass _cc)
        {
            InitializeComponent();
            cc = _cc;
            frm12 = new Form12(cc);
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            if (lblPassInfo.Visible)
                lblPassInfo.Visible = false;
            if (lblUserInfo.Visible)
                lblUserInfo.Visible = false;
            
            if (txtUser.Text == "Admin" && txtPass.Text == "password")
            {
                if (!frm12.Visible)
                {
                    if (frm12.IsDisposed)
                    {
                        frm12 = new Form12(cc);
                        frm12.Show();
                    }
                    else
                        frm12.Show();

                    this.Close();
                }
            }
            else if (txtUser.Text != "Admin" && txtPass.Text != "password")
            {
                lblUserInfo.Visible = true;
                lblPassInfo.Visible = true;
                txtUser.Focus();
            }
            else if (txtUser.Text != "Admin")
            {
                lblUserInfo.Visible = true;
                txtUser.Focus();
            }
            else if (txtPass.Text != "password")
            {
                lblPassInfo.Visible = true;
                txtPass.Focus();
            }
        }
    }
}
