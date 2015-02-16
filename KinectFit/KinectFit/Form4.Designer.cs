namespace KinectFit
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.infoLogo = new System.Windows.Forms.PictureBox();
            this.lblInfo1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.cmbStyles = new System.Windows.Forms.ComboBox();
            this.lblStyleTip = new System.Windows.Forms.Label();
            this.lblStyle = new System.Windows.Forms.Label();
            this.lblConnection = new System.Windows.Forms.Label();
            this.connectionPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.infoLogo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.connectionPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // infoLogo
            // 
            this.infoLogo.BackgroundImage = global::KinectFit.Properties.Resources.small_kinect;
            this.infoLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.infoLogo.Location = new System.Drawing.Point(718, 1);
            this.infoLogo.Name = "infoLogo";
            this.infoLogo.Size = new System.Drawing.Size(63, 65);
            this.infoLogo.TabIndex = 2;
            this.infoLogo.TabStop = false;
            // 
            // lblInfo1
            // 
            this.lblInfo1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo1.ForeColor = System.Drawing.Color.Black;
            this.lblInfo1.Location = new System.Drawing.Point(12, 1);
            this.lblInfo1.Name = "lblInfo1";
            this.lblInfo1.Size = new System.Drawing.Size(700, 65);
            this.lblInfo1.TabIndex = 4;
            this.lblInfo1.Text = "Pick a style from [Brand]";
            this.lblInfo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 202);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 60);
            this.panel1.TabIndex = 11;
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(438, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 46);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseEnter += new System.EventHandler(this.btnBack_MouseEnter);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            // 
            // btnNext
            // 
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(212, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(120, 46);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            this.btnNext.MouseEnter += new System.EventHandler(this.btnNext_MouseEnter);
            this.btnNext.MouseLeave += new System.EventHandler(this.btnNext_MouseLeave);
            // 
            // cmbStyles
            // 
            this.cmbStyles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.cmbStyles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStyles.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStyles.FormattingEnabled = true;
            this.cmbStyles.Items.AddRange(new object[] {
            "Select a Style"});
            this.cmbStyles.Location = new System.Drawing.Point(213, 90);
            this.cmbStyles.Name = "cmbStyles";
            this.cmbStyles.Size = new System.Drawing.Size(275, 33);
            this.cmbStyles.TabIndex = 14;
            this.cmbStyles.SelectedIndexChanged += new System.EventHandler(this.cmbStyles_SelectedIndexChanged);
            // 
            // lblStyleTip
            // 
            this.lblStyleTip.AutoSize = true;
            this.lblStyleTip.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStyleTip.ForeColor = System.Drawing.Color.Red;
            this.lblStyleTip.Location = new System.Drawing.Point(547, 93);
            this.lblStyleTip.Name = "lblStyleTip";
            this.lblStyleTip.Size = new System.Drawing.Size(120, 25);
            this.lblStyleTip.TabIndex = 13;
            this.lblStyleTip.Text = "Select a style";
            this.lblStyleTip.Visible = false;
            // 
            // lblStyle
            // 
            this.lblStyle.AutoSize = true;
            this.lblStyle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStyle.Location = new System.Drawing.Point(64, 89);
            this.lblStyle.Name = "lblStyle";
            this.lblStyle.Size = new System.Drawing.Size(68, 30);
            this.lblStyle.TabIndex = 12;
            this.lblStyle.Text = "Style :";
            // 
            // lblConnection
            // 
            this.lblConnection.AutoSize = true;
            this.lblConnection.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnection.Location = new System.Drawing.Point(81, 45);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(195, 21);
            this.lblConnection.TabIndex = 16;
            this.lblConnection.Text = "Not connected to database";
            // 
            // connectionPicture
            // 
            this.connectionPicture.BackgroundImage = global::KinectFit.Properties.Resources.offline;
            this.connectionPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.connectionPicture.Location = new System.Drawing.Point(12, 1);
            this.connectionPicture.Name = "connectionPicture";
            this.connectionPicture.Size = new System.Drawing.Size(63, 65);
            this.connectionPicture.TabIndex = 15;
            this.connectionPicture.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(793, 262);
            this.Controls.Add(this.lblConnection);
            this.Controls.Add(this.connectionPicture);
            this.Controls.Add(this.cmbStyles);
            this.Controls.Add(this.lblStyleTip);
            this.Controls.Add(this.lblStyle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblInfo1);
            this.Controls.Add(this.infoLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.infoLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.connectionPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox infoLogo;
        private System.Windows.Forms.Label lblInfo1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ComboBox cmbStyles;
        private System.Windows.Forms.Label lblStyleTip;
        private System.Windows.Forms.Label lblStyle;
        private System.Windows.Forms.Label lblConnection;
        private System.Windows.Forms.PictureBox connectionPicture;
    }
}