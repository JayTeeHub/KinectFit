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
    public partial class MainForm : Form
    {
        FitForm frm2; //Form 2 object
        AuthForm frm11; //Form 11 object
        ConnectionClass cc; //ConnectionClass object for holding all database related information
        public MainForm()
        {
            InitializeComponent();
            cc = new ConnectionClass();//Database connection parameters are established here, see ConnectionClass.cs for more details. Hint: highlight and hit F12.
            frm2 = new FitForm(cc); //Form2 is initiailzed and passed in ConnectionClass object but Form2 is not loaded.
            frm11 = new AuthForm(cc); //Form11 is initialized and passed in ConnectionClass object but Form11 is not loaded.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0); //Center form location
            this.Size = Screen.PrimaryScreen.WorkingArea.Size; //Make form size equal the screen size this software is running on.
            welcomePanel.Left = (this.Width - welcomePanel.Width) / 2; //Center panel in middle of screen for user
            welcomePanel.Top = (this.Height - welcomePanel.Height) / 2; //Center panel in middle of screen for user.

            cc.OpenConnection(); //Attempt a connection with MySQL database.
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!frm2.Visible)//Checks if the FitForm is already made being shown to the user 
            {
                if (frm2.IsDisposed)//Checks the FitForm object to see if it's already been used before or not.
                {
                    frm2 = new FitForm(cc);//Creates new FitForm object
                    frm2.Show();//Then opens the form
                }
                else
                    frm2.Show();//If it hasn't been used yet, then open the form.
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (!frm11.Visible)//Checks if the AuthForm is already made being shown to the user 
            {
                if (frm11.IsDisposed)//Checks the AuthForm object to see if it's already been used before or not.
                {
                    frm11 = new AuthForm(cc);//Creates new AuthForm object
                    frm11.Show();//Then opens the form
                }
                else
                    frm11.Show();//If it hasn't been used yet, then open the form.
            }
        }

    }
}
