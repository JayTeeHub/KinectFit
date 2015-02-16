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
    public partial class SimilarForm : Form
    {
        public ConnectionClass cc;
        DataTable dt;
        String statement;
        public SimilarForm(ConnectionClass _cc)
        {
            InitializeComponent();
            cc = _cc;
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            if (cc.isConnected())
            {
                connectionPicture.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.connect));
                statement = "select distinct(brand) from clothes WHERE gender = '" + cc.UserGender + "'AND size = '" + cc.UserSize + "' AND sizeQty >= 1 and type != 'Trousers' AND brand != '"+ cc.UserBrand +"';";
                dt = new DataTable();
                dt = cc.queryResults(statement);
                if (dt != null)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        string item = string.Format("{0}", row.ItemArray[0]);
                        listBrands.Items.Add(item);
                    }


                }
                else if (!cc.isConnected())
                {
                    connectionPicture.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.offline));
                    

                    cc.OpenConnection();
                    if (cc.isConnected())
                    {
                        connectionPicture.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.connect));
                       
                    }
                    else
                    {
                        connectionPicture.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.offline));
                
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ProductForm frm8 = new ProductForm(cc);
            frm8.Show();
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

        private void listBrands_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = "";
            if (cc.UserStyle != "Trousers")
                type = "shirt";
            else
                type = "trousers";
            listClothes.Items.Clear();
            statement = "select name from clothes WHERE gender = '" + cc.UserGender + "'AND size = '" + cc.UserSize + "' AND sizeQty >= 1 and type != trousers AND brand = '" + listBrands.SelectedItem.ToString() + "';";
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
        }

        private void listClothes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = "";
            statement = "select type from clothes where name = '" + listClothes.SelectedItem.ToString() + "'";
            dt = new DataTable();
            dt = cc.queryResults(statement);
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    type = row.ItemArray[0].ToString();
                }
            }
            
            statement = "select sizeQty,location,price from clothes WHERE name = '" + listClothes.SelectedItem.ToString() + "' AND gender = '" + cc.UserGender + "' AND brand = '" + listBrands.SelectedItem.ToString() + "' AND size = '" + cc.UserSize + "' AND sizeQty >= 1;";
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
