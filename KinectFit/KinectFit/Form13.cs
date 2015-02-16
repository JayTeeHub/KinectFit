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
    public partial class Form13 : Form
    {
        ConnectionClass cc;
        String statement;
        public Form13(ConnectionClass _cc)
        {
            InitializeComponent();
            cc = _cc;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
