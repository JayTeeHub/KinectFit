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
    
    public partial class SelectForm : Form
    {
        StyleForm frm4;
        public ConnectionClass cc;
        DataTable dt;
        String statement;
        public SelectForm(ConnectionClass _cc)
        {
            InitializeComponent();
            cc = _cc;
            frm4 = new StyleForm(cc);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            cmbBrands.SelectedItem = "Select a Brand";
            cmbGenders.SelectedItem = "Select a Gender";

            if (cc.isConnected())
            {
                connectionPicture.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.connect));
                lblConnection.Text = "Connected to database";

                statement = "select DISTINCT(brand) from clothes";//MySQL statement to obtain brands from the clothes table
                dt = new DataTable();
                dt = cc.queryResults(statement);//call queryResults function to obtain results of statement
                if (dt != null)//There has to be results, impossible for there to be no brands in database
                {
                    foreach (DataRow row in dt.Rows)//Go through each result obtained 
                    {
                        string brand = string.Format("{0}", row.ItemArray[0]);//Every brand is in the first element of the array
                        cmbBrands.Items.Add(brand);//Add each brand to the combo box list.
                    }
                }
                else if (!cc.isConnected())//Clearly something happened with the database connection if no brands can be found.
                {                          //If connection is good then database table may be damaged, beyond the scope of this application is a check for that.
                    connectionPicture.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.offline));
                    lblConnection.Text = "Restablishing connection....";

                    cc.OpenConnection();//Lets try reconnected
                    if (cc.isConnected())
                    {
                        connectionPicture.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.connect));
                        lblConnection.Text = "Connected to database";
                    }
                    else
                    {
                        connectionPicture.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.offline));
                        lblConnection.Text = "Database is offline at this time, please contact admin";//Database connection couldn't be made, get on that!
                    }


                }
                
                if (cc.isConnected())
                {
                    connectionPicture.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.connect));
                    lblConnection.Text = "Connected to database";

                    statement = "select DISTINCT(gender) from clothes";//MySQL statement to obtain genders from the clothes table
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
            if (cmbGenders.SelectedIndex <= 0 && cmbBrands.SelectedIndex <= 0)//Checks if the user has made any selection before trying to move on
            {
                lblGenderTip.Visible = true;//shows user they need to pick a gender
                lblBrandTip.Visible = true;//shows user they need to pick a brand
            }
            else if (cmbGenders.SelectedIndex <= 0)
                lblGenderTip.Visible = true;
            else if (cmbBrands.SelectedIndex <= 0)
                lblBrandTip.Visible = true;
            else if (cmbGenders.SelectedIndex > 0 && cmbBrands.SelectedIndex > 0)//Once the user has selected a gender and brand move on.
            {
                //Store selections into ConnectionClass properites
                cc.UserBrand = cmbBrands.SelectedItem.ToString();
                cc.UserGender = cmbGenders.SelectedItem.ToString();

                if (!frm4.Visible)
                {
                    if (frm4.IsDisposed)
                    {
                        frm4 = new StyleForm(cc);
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
