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
    public partial class Form10 : Form
    {
        ConnectionClass cc;
        public Form10(ConnectionClass _cc)
        {
            InitializeComponent();
            cc = _cc;
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            timer1.Interval = 3000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
