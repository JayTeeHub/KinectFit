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
    public partial class Form12 : Form
    {
        Form13 frm13;
        ConnectionClass cc;
        String statement;
        int cid = 0;
        DataTable dt;
        public Form12(ConnectionClass _cc)
        {
            InitializeComponent();
            cc = _cc;
            frm13 = new Form13(cc);

        }

        private void Form12_Load(object sender, EventArgs e)
        {
            if (cc.isConnected())
            {
                statement = "select DISTINCT(brand) from clothes";
                dt = new DataTable();
                dt = cc.queryResults(statement);
                if (dt != null)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        string brand = string.Format("{0}", row.ItemArray[0]);
                        cmbBrands.Items.Add(brand);
                        comboBox1.Items.Add(brand);
                    }
                }
            }
            if (cc.isConnected())
            {
                statement = "select DISTINCT(gender) from clothes";
                dt = new DataTable();
                dt = cc.queryResults(statement);
                if (dt != null)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        string brand = string.Format("{0}", row.ItemArray[0]);
                        cmbGenders.Items.Add(brand);
                        comboBox2.Items.Add(brand);
                    }
                }
            }
            if (cc.isConnected())
            {
                statement = "select name from restock WHERE estDate = Date(NOW())";
                dt = new DataTable();
                dt = cc.queryResults(statement);
                if (dt != null)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        string brand = string.Format("{0}", row.ItemArray[0]);
                        listBox1.Items.Add(brand);
                    }
                }
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (panelAdd.Visible)
                panelAdd.Visible = false;
            if (!panelUpdate.Visible)
                panelUpdate.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
          
            if (!panelAdd.Visible)
                panelAdd.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!frm13.Visible)
            {
                if (frm13.IsDisposed)
                {
                    frm13 = new Form13(cc);
                    frm13.Show();
                }
                else
                    frm13.Show();

                this.Close();
            }

        }

        private void cmbGenders_SelectedIndexChanged(object sender, EventArgs e)
        {
            cc.UserGender = cmbGenders.SelectedItem.ToString();
            if (cmbBrands.SelectedIndex > 0)
            {
                lblStyle.Visible = true;
                cmbStyles.Visible = true;
                getStyle();
            }
        }

        private void cmbBrands_SelectedIndexChanged(object sender, EventArgs e)
        {
            cc.UserBrand = cmbBrands.SelectedItem.ToString();
            if (cmbGenders.SelectedIndex > 0)
            {
                lblStyle.Visible = true;
                cmbStyles.Visible = true;
                getStyle();
            }
        }

        private void cmbStyles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStyles.SelectedIndex > 0)
            {
                lblProducts.Visible = true;
                listClothes.Visible = true;
                lblSize.Visible = true;
                checkS.Visible = true;
                checkM.Visible = true;
                checkL.Visible = true;
                checkXL.Visible = true;
                cc.TrueStyle = cmbStyles.SelectedItem.ToString();
                getProducts();
            }

        }

        private void getStyle()
        {
            if (cc.isConnected())
            {
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
            }
        }

        private void getProducts()
        {
            if (cc.isConnected())
            {
                statement = "select DISTINCT(name) from clothes WHERE gender = '" + cc.UserGender + "' AND brand = '" + cc.UserBrand + "' AND type = '" + cc.TrueStyle + "' AND sizeQty >= 1;";
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
        }

        private void checkS_CheckStateChanged(object sender, EventArgs e)
        {
            
            if (checkXL.Checked || checkM.Checked || checkL.Checked)
            {
                checkXL.Checked = false;
                checkM.Checked = false;
                checkL.Checked = false;
            }

         
        }

        private void checkM_CheckedChanged(object sender, EventArgs e)
        {
            

            if (checkS.Checked || checkXL.Checked || checkL.Checked)
            {
                checkS.Checked = false;
                checkXL.Checked = false;
                checkL.Checked = false;
            }
           
        }

        private void checkL_CheckedChanged(object sender, EventArgs e)
        {
            

            if (checkS.Checked || checkM.Checked || checkXL.Checked)
            {
                checkS.Checked = false;
                checkM.Checked = false;
                checkXL.Checked = false;
            }

            
        }

        private void checkXL_CheckedChanged(object sender, EventArgs e)
        {
            

            if (checkS.Checked || checkM.Checked || checkL.Checked)
            {
                checkS.Checked = false;
                checkM.Checked = false;
                checkL.Checked = false;
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.ToString());
        }

        private void listClothes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkL.Checked || checkS.Checked || checkM.Checked || checkL.Checked)
            {
                lblEst.Visible = true;
                dateTimePicker1.Visible = true;
                lblQty.Visible = true;
                txtQty.Visible = true;
            }
        }

        private String getSize()
        {
            if (checkS.Checked)
                return "S";
            else if (checkM.Checked)
                return "M";
            else if (checkL.Checked)
                return "L";
            else if (checkXL.Checked)
                return "XL";
            else
                return "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = listClothes.SelectedItem.ToString();
            string size = getSize();
            int sizeAmt = Convert.ToInt32(txtQty.Text);
            DateTime estDate = dateTimePicker1.Value.Date;
            int cid=0;
            if (cc.isConnected())
            {
                statement = "select cid from clothes WHERE gender = '" + cc.UserGender + "' AND size = '" + size + "' AND type = '" + cc.TrueStyle + "' AND name = '" + name + "' AND brand = '" + cc.UserBrand + "';";

                dt = new DataTable();
                dt = cc.queryResults(statement);
                if (dt != null)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        string brand = string.Format("{0}", row.ItemArray[0]);
                        cid = Convert.ToInt32(brand);
                    }
                }
            }

            if (cc.isConnected())
            {
                statement = "INSERT INTO restock (brand, gender, name, type, size, sizeAmt, estDate, cid) VALUES (?brand, ?gender, ?name, ?type, ?size, ?sizeAmt, ?estDate, ?cid)";
                cc.Insert(statement, name, size, sizeAmt, estDate, cid);
            }
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtQty.Text) > 0 && Convert.ToInt32(txtQty.Text) <= 50 )
            {
                btnSubmit.Enabled = true;
            }

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Add to Brand code 
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Visible)
            {
                if (listBox1.SelectedIndex >= 0)
                {
                    statement = "update clothes c INNER JOIN restock r ON c.cid = r.cid SET c.sizeQty = c.sizeQty + r.sizeAmt WHERE r.cid = '"+ cid +"'";
                    if (cc.Update(statement))
                    {
                        statement = "delete from restock WHERE cid = '" + cid + "'";
                        cc.Delete(statement);
                        listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                    }

                }
            }
            if (comboBox1.Visible)
            {
                statement = "insert into clothes (brand, gender, name, type, size) values (?brand, ?gender, ?name, ?type, ?size)";
                cc.StyleInsert(statement, textBox1.Text, textBox4.Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Visible = !listBox1.Visible;
            label2.Visible = !label2.Visible;

            label9.Visible = !label9.Visible;
            textBox4.Visible = !textBox4.Visible;
            listBox2.Visible = !listBox2.Visible;
            label1.Visible = !label1.Visible;
            comboBox2.Visible = !comboBox2.Visible;
            label3.Visible = !label3.Visible;
            comboBox1.Visible = !comboBox1.Visible;
            label4.Visible = !label4.Visible;
            label5.Visible = !label5.Visible;
            textBox1.Visible = !textBox1.Visible;



        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cc.isConnected())
            {
                if (listBox1.SelectedIndex >= 0)
                {
                    button1.Enabled = true;
                    int i = 0;
                    statement = "select cid from restock WHERE name = '" + listBox1.SelectedItem.ToString() + "'";
                    dt = new DataTable();
                    dt = cc.queryResults(statement);
                    if (dt != null)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            i++;
                            if (i == 1)
                            {
                                string brand = string.Format("{0}", row.ItemArray[0]);
                                cid = Convert.ToInt32(brand);
                            }
                        }
                    }

                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            
            cc.UserBrand = comboBox1.SelectedItem.ToString();
            if (comboBox2.SelectedIndex >= 0)
            {
                if (cc.isConnected())
                {
                    statement = "select DISTINCT(type) from clothes WHERE gender = '" + cc.UserGender + "' AND brand = '" + cc.UserBrand + "';";

                    dt = new DataTable();
                    dt = cc.queryResults(statement);
                    if (dt != null)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            string brand = string.Format("{0}", row.ItemArray[0]);
                            listBox2.Items.Add(brand);
                        }
                    }
                }
                if (cc.isConnected())
                {
                    if(cc.UserBrand == "zara")
                        statement = "select distinct(part) from zaraSize where gender = '" + cc.UserGender +"'";
                    else if(cc.UserBrand == "")
                        statement = "select distinct(part) from zaraSize where gender = '" + cc.UserGender + "'";
                    else if (cc.UserBrand == "")
                        statement = "select distinct(part) from zaraSize where gender = '" + cc.UserGender + "'";
                    else if (cc.UserBrand == "")
                        statement = "select distinct(part) from zaraSize where gender = '" + cc.UserGender + "'";
                    else if (cc.UserBrand == "")
                        statement = "select distinct(part) from zaraSize where gender = '" + cc.UserGender + "'";

                    dt = new DataTable();
                    dt = cc.queryResults(statement);
                    if (dt != null)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            string brand = string.Format("{0}", row.ItemArray[0]);
                           
                        }
                    }
                }
                listBox2.Visible = true;
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            
            cc.UserGender = comboBox2.SelectedItem.ToString();
            if (comboBox1.SelectedIndex >= 0)
            {
                if (cc.isConnected())
                {
                    statement = "select DISTINCT(type) from clothes WHERE gender = '" + cc.UserGender + "' AND brand = '" + cc.UserBrand + "';";

                    dt = new DataTable();
                    dt = cc.queryResults(statement);
                    if (dt != null)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            string brand = string.Format("{0}", row.ItemArray[0]);
                            listBox2.Items.Add(brand);
                        }
                    }
                }
                if (cc.isConnected())
                {
                    if (cc.UserBrand == "zara")
                        statement = "select distinct(part) from zaraSize where gender = '" + cc.UserGender + "'";
                    else if (cc.UserBrand == "H&M")
                        statement = "select distinct(part) from hmSize where gender = '" + cc.UserGender + "'";
                    else if (cc.UserBrand == "Gap")
                        statement = "select distinct(part) from gapSize where gender = '" + cc.UserGender + "'";
                    else if (cc.UserBrand == "Hugo Boss")
                        statement = "select distinct(part) from hugoBossSize where gender = '" + cc.UserGender + "'";
                    else if (cc.UserBrand == "Urban Outfitters")
                        statement = "select distinct(part) from urbanOutfittersSize where gender = '" + cc.UserGender + "'";

                    dt = new DataTable();
                    dt = cc.queryResults(statement);
                    if (dt != null)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            string brand = string.Format("{0}", row.ItemArray[0]);
                        }
                    }
                }
                listBox2.Visible = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text != "" && textBox4.Text != "")
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text != "" && textBox4.Text != "")
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

    }
}
