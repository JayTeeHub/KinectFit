namespace KinectFit
{
    partial class SelectForm
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
            this.lblInfo1 = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblBrandTip = new System.Windows.Forms.Label();
            this.lblGenderTip = new System.Windows.Forms.Label();
            this.cmbGenders = new System.Windows.Forms.ComboBox();
            this.cmbBrands = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblConnection = new System.Windows.Forms.Label();
            this.connectionPicture = new System.Windows.Forms.PictureBox();
            this.infoLogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.connectionPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfo1
            // 
            this.lblInfo1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo1.ForeColor = System.Drawing.Color.Black;
            this.lblInfo1.Location = new System.Drawing.Point(12, 9);
            this.lblInfo1.Name = "lblInfo1";
            this.lblInfo1.Size = new System.Drawing.Size(700, 65);
            this.lblInfo1.TabIndex = 3;
            this.lblInfo1.Text = "Make a selection";
            this.lblInfo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(13, 92);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(91, 30);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "Gender :";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.Location = new System.Drawing.Point(433, 96);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(87, 30);
            this.lblBrand.TabIndex = 5;
            this.lblBrand.Text = "Brands :";
            // 
            // lblBrandTip
            // 
            this.lblBrandTip.AutoSize = true;
            this.lblBrandTip.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrandTip.ForeColor = System.Drawing.Color.Red;
            this.lblBrandTip.Location = new System.Drawing.Point(433, 143);
            this.lblBrandTip.Name = "lblBrandTip";
            this.lblBrandTip.Size = new System.Drawing.Size(132, 25);
            this.lblBrandTip.TabIndex = 6;
            this.lblBrandTip.Text = "Select a brand";
            this.lblBrandTip.Visible = false;
            // 
            // lblGenderTip
            // 
            this.lblGenderTip.AutoSize = true;
            this.lblGenderTip.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenderTip.ForeColor = System.Drawing.Color.Red;
            this.lblGenderTip.Location = new System.Drawing.Point(13, 143);
            this.lblGenderTip.Name = "lblGenderTip";
            this.lblGenderTip.Size = new System.Drawing.Size(142, 25);
            this.lblGenderTip.TabIndex = 7;
            this.lblGenderTip.Text = "Select a gender";
            this.lblGenderTip.Visible = false;
            // 
            // cmbGenders
            // 
            this.cmbGenders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.cmbGenders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbGenders.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGenders.FormattingEnabled = true;
            this.cmbGenders.Items.AddRange(new object[] {
            "Select a Gender"});
            this.cmbGenders.Location = new System.Drawing.Point(162, 93);
            this.cmbGenders.Name = "cmbGenders";
            this.cmbGenders.Size = new System.Drawing.Size(170, 33);
            this.cmbGenders.TabIndex = 8;
            this.cmbGenders.SelectedIndexChanged += new System.EventHandler(this.cmbGenders_SelectedIndexChanged);
            // 
            // cmbBrands
            // 
            this.cmbBrands.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.cmbBrands.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBrands.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBrands.FormattingEnabled = true;
            this.cmbBrands.Items.AddRange(new object[] {
            "Select a Brand"});
            this.cmbBrands.Location = new System.Drawing.Point(611, 92);
            this.cmbBrands.Name = "cmbBrands";
            this.cmbBrands.Size = new System.Drawing.Size(170, 33);
            this.cmbBrands.TabIndex = 9;
            this.cmbBrands.SelectedIndexChanged += new System.EventHandler(this.cmbBrands_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Location = new System.Drawing.Point(0, 204);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 58);
            this.panel1.TabIndex = 10;
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(438, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 46);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.MouseEnter += new System.EventHandler(this.btnCancel_MouseEnter);
            this.btnCancel.MouseLeave += new System.EventHandler(this.btnCancel_MouseLeave);
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
            // lblConnection
            // 
            this.lblConnection.AutoSize = true;
            this.lblConnection.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnection.Location = new System.Drawing.Point(81, 53);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(195, 21);
            this.lblConnection.TabIndex = 13;
            this.lblConnection.Text = "Not connected to database";
            // 
            // connectionPicture
            // 
            this.connectionPicture.BackgroundImage = global::KinectFit.Properties.Resources.offline;
            this.connectionPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.connectionPicture.Location = new System.Drawing.Point(12, 9);
            this.connectionPicture.Name = "connectionPicture";
            this.connectionPicture.Size = new System.Drawing.Size(63, 65);
            this.connectionPicture.TabIndex = 12;
            this.connectionPicture.TabStop = false;
            // 
            // infoLogo
            // 
            this.infoLogo.BackgroundImage = global::KinectFit.Properties.Resources.small_kinect;
            this.infoLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.infoLogo.Location = new System.Drawing.Point(718, 9);
            this.infoLogo.Name = "infoLogo";
            this.infoLogo.Size = new System.Drawing.Size(63, 65);
            this.infoLogo.TabIndex = 11;
            this.infoLogo.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(793, 262);
            this.Controls.Add(this.lblConnection);
            this.Controls.Add(this.connectionPicture);
            this.Controls.Add(this.infoLogo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbBrands);
            this.Controls.Add(this.cmbGenders);
            this.Controls.Add(this.lblGenderTip);
            this.Controls.Add(this.lblBrandTip);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.connectionPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infoLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo1;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblBrandTip;
        private System.Windows.Forms.Label lblGenderTip;
        private System.Windows.Forms.ComboBox cmbGenders;
        private System.Windows.Forms.ComboBox cmbBrands;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.PictureBox infoLogo;
        private System.Windows.Forms.PictureBox connectionPicture;
        private System.Windows.Forms.Label lblConnection;
    }
}