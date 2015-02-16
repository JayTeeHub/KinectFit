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
    
    public partial class Form3 : Form
    {
        Form4 frm4;
        public ConnectionClass cc;
        DataTable dt;
        String statement;
        public Form3(ConnectionClass _cc)
        {
            InitializeComponent();
            cc = _cc;
            frm4 = new Form4(cc);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            cmbBrands.SelectedItem = "Select a Brand";
            cmbGenders.SelectedItem = "Select a Gender";

            if (cc.isConnected())
            {
                connectionPicture.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.connect));
                lblConnection.Text = "Connected to database";

                statement = "select DISTINCT(brand) from clothes";
                dt = new DataTable();
                dt = cc.queryResults(statement);
                if (dt != null)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        string brand = string.Format("{0}", row.ItemArray[0]);
                        cmbBrands.Items.Add(brand);
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
                
                if (cc.isConnected())
                {
                    connectionPicture.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.connect));
                    lblConnection.Text = "Connected to database";

                    statement = "select DISTINCT(gender) from clothes";
                    dt = new DataTable();
                    dt = cc.queryResults(statement);
                    if (dt != null)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            string brand = string.Format("{0}", row.ItemArray[0]);
                            cmbGenders.Items.Add(brand);
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

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (cmbGenders.SelectedIndex <= 0 && cmbBrands.SelectedIndex <= 0)
            {
                lblGenderTip.Visible = true;
                lblBrandTip.Visible = true;
            }
            else if (cmbGenders.SelectedIndex <= 0)
                lblGenderTip.Visible = true;
            else if (cmbBrands.SelectedIndex <= 0)
                lblBrandTip.Visible = true;
            else if (cmbGenders.SelectedIndex > 0 && cmbBrands.SelectedIndex > 0)
            {
                cc.UserBrand = cmbBrands.SelectedItem.ToString();
                cc.UserGender = cmbGenders.SelectedItem.ToString();

                if (!frm4.Visible)
                {
                    if (frm4.IsDisposed)
                    {
                        frm4 = new Form4(cc);
                        frm4.Show();
                    }
                    else
                        frm4.Show();

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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_MouseEnter(object sender, EventArgs e)
        {
            if (btnCancel.BackColor == Color.Black)
                btnCancel.BackColor = Color.Gray;
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            if (btnCancel.BackColor == Color.Gray)
                btnCancel.BackColor = Color.Black;
        }

        private void cmbGenders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lblGenderTip.Visible == true)
                lblGenderTip.Visible = false;
        }

        private void cmbBrands_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lblBrandTip.Visible == true)
                lblBrandTip.Visible = false;
        }
    }
}
