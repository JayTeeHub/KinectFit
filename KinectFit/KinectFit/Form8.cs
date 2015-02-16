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
    public partial class Form8 : Form
    {
        Form9 frm9;
        ConnectionClass cc;
        DataTable dt;
        String statement;
        public Form8(ConnectionClass _cc)
        {
            InitializeComponent();
            cc = _cc;
            frm9 = new Form9(cc);
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            if (cc.isConnected())
            {
                connectionPicture.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.connect));
                lblConnection.Text = "Connected to database";

                lblInfo1.Text = "Products avaliable for " + cc.UserBrand + "'s " + cc.UserStyle;
                statement = "select name from clothes WHERE gender = '" + cc.UserGender + "' AND brand = '" + cc.UserBrand + "' AND type = '" + cc.TrueStyle +"' AND size = '" + cc.UserSize + "' AND sizeQty >= 1;";
                dt = new DataTable();
                dt = cc.queryResults(statement);
                if (dt != null)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        string item = string.Format("{0}", row.ItemArray[0]);
                        listClothes.Items.Add(item);
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
            if (!frm9.Visible)
            {
                if (frm9.IsDisposed)
                {
                    frm9 = new Form9(cc);
                    frm9.Show();
                }
                else
                    frm9.Show();

                this.Close();
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

        private void btnFinished_Click(object sender, EventArgs e)
        {
            Form10 frm10 = new Form10(cc);
            frm10.Show();
            this.Close();
        }

        private void btnFinished_MouseEnter(object sender, EventArgs e)
        {
            if (btnFinished.BackColor == Color.Black)
                btnFinished.BackColor = Color.Gray;
        }

        private void btnFinished_MouseLeave(object sender, EventArgs e)
        {
            if (btnFinished.BackColor == Color.Gray)
                btnFinished.BackColor = Color.Black;
        }

        private void listClothes_SelectedIndexChanged(object sender, EventArgs e)
        {
            statement = "select sizeQty,location,price from clothes WHERE name = '"+ listClothes.SelectedItem.ToString() +"' AND gender = '" + cc.UserGender + "' AND brand = '" + cc.UserBrand + "' AND type = '" + cc.TrueStyle + "' AND size = '" + cc.UserSize + "' AND sizeQty >= 1;";
            dt = new DataTable();
            dt = cc.queryResults(statement);
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    lblQtyValue.Text = row.ItemArray[0].ToString();
                    lblLocationValue.Text = row.ItemArray[1].ToString();
                    lblPriceValue.Text = row.ItemArray[2].ToString();
                }
            }
        }
    }
}
