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
    public partial class Form7 : Form
    {
        ProductForm frm8;
        ConnectionClass cc;
        public Form7(ConnectionClass _cc)
        {
            InitializeComponent();
            cc = _cc;
            frm8 = new ProductForm(cc);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            StyleForm frm4 = new StyleForm(cc);
            frm4.Show();
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!frm8.Visible)
            {
                if (frm8.IsDisposed)
                {
                    frm8 = new ProductForm(cc);
                    frm8.Show();
                }
                else
                    frm8.Show();

                this.Close();
            }
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            lblInfo2.Text = "Here is your size for " + cc.UserBrand + "'s " + cc.UserStyle;
            lblValue.Text = cc.UserSize;
        }
    }
}
