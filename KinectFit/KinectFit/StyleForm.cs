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
    public partial class StyleForm : Form
    {
        KLoadForm frm5;
        ConnectionClass cc;
        DataTable dt;
        String statement;
        public StyleForm(ConnectionClass _cc)
        {
            InitializeComponent();
            cc = _cc;
            frm5 = new KLoadForm(cc);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            cmbStyles.SelectedItem = "Select a Style";
            if (cc.isConnected())
            {
                connectionPicture.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.connect));
                lblConnection.Text = "Connected to database";
                
                lblInfo1.Text = "Pick a style from " + cc.UserBrand;
                statement = "select DISTINCT(type) from clothes WHERE gender = '" + cc.UserGender + "' AND brand = '" + cc.UserBrand + "';";
                dt = new DataTable();
                dt = cc.queryResults(statement);
                if (dt != null)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        string brand = string.Format("{0}", row.ItemArray[0]);
                        cmbStyles.Items.Add(brand);
                    }
                }
                else if (!cc.isConnected())
                {
                    connectionPicture.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.offline));
                    lblConnection.Text = "Restablishing connection....";

                    cc.OpenConnection();
                    if (cc.isConnected())
                    {
                        connectionPicture.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.connect));
                        lblConnection.Text = "Connected to database";
                    }
                    else
                    {
                        connectionPicture.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.offline));
                        lblConnection.Text = "Database is offline at this time, please contact someone";
                    }
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (cmbStyles.SelectedIndex <= 0)
            {
                lblStyleTip.Visible = true;
                
            }
            else if (cmbStyles.SelectedIndex > 0)
            {
                if (cmbStyles.SelectedItem.ToString() != "Trousers")
                {
                    cc.TrueStyle = cmbStyles.SelectedItem.ToString();
                    cc.UserStyle = "Shirt";
                }
                else
                {
                    cc.TrueStyle = cmbStyles.SelectedItem.ToString();
                    cc.UserStyle = cmbStyles.SelectedItem.ToString();
                }

                if (!frm5.Visible)
                {
                    if (frm5.IsDisposed)
                    {
                        frm5 = new KLoadForm(cc);
                        frm5.Show();
                    }
                    else
                        frm5.Show();

                    this.Close();
                }
            }
        }

        private void btnNext_MouseEnter(object sender, EventArgs e)
        {
            if (btnNext.BackColor == Color.Black)
                btnNext.BackColor = Color.Gray;
        }

        private void btnNext_MouseLeave(object sender, EventArgs e)
        {
            if (btnNext.BackColor == Color.Gray)
                btnNext.BackColor = Color.Black;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SelectForm frm3 = new SelectForm(cc);
            frm3.Show();
            this.Close();
        }

        private void btnBack_MouseEnter(object sender, EventArgs e)
        {
            if (btnBack.BackColor == Color.Black)
                btnBack.BackColor = Color.Gray;
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            if (btnBack.BackColor == Color.Gray)
                btnBack.BackColor = Color.Black;
        }

        private void cmbStyles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lblStyleTip.Visible == true)
                lblStyleTip.Visible = false;
        }
    }
}
