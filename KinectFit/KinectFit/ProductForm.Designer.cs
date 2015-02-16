namespace KinectFit
{
    partial class ProductForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFinished = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblInfo1 = new System.Windows.Forms.Label();
            this.listClothes = new System.Windows.Forms.ListBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblLocationValue = new System.Windows.Forms.Label();
            this.lblPriceValue = new System.Windows.Forms.Label();
            this.lblQtyValue = new System.Windows.Forms.Label();
            this.infoLogo = new System.Windows.Forms.PictureBox();
            this.lblConnection = new System.Windows.Forms.Label();
            this.connectionPicture = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnFinished);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Location = new System.Drawing.Point(0, 204);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 58);
            this.panel1.TabIndex = 11;
            // 
            // btnFinished
            // 
            this.btnFinished.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinished.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinished.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinished.ForeColor = System.Drawing.Color.White;
            this.btnFinished.Location = new System.Drawing.Point(438, 3);
            this.btnFinished.Name = "btnFinished";
            this.btnFinished.Size = new System.Drawing.Size(120, 46);
            this.btnFinished.TabIndex = 7;
            this.btnFinished.Text = "Finished";
            this.btnFinished.UseVisualStyleBackColor = true;
            this.btnFinished.Click += new System.EventHandler(this.btnFinished_Click);
            this.btnFinished.MouseEnter += new System.EventHandler(this.btnFinished_MouseEnter);
            this.btnFinished.MouseLeave += new System.EventHandler(this.btnFinished_MouseLeave);
            // 
            // btnNext
            // 
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(164, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(194, 46);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Size in other brands";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            this.btnNext.MouseEnter += new System.EventHandler(this.btnNext_MouseEnter);
            this.btnNext.MouseLeave += new System.EventHandler(this.btnNext_MouseLeave);
            // 
            // lblInfo1
            // 
            this.lblInfo1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo1.ForeColor = System.Drawing.Color.Black;
            this.lblInfo1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblInfo1.Location = new System.Drawing.Point(12, 2);
            this.lblInfo1.Name = "lblInfo1";
            this.lblInfo1.Size = new System.Drawing.Size(700, 65);
            this.lblInfo1.TabIndex = 13;
            this.lblInfo1.Text = "Products avaliable in your  [Brand]\'s [Style]";
            this.lblInfo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listClothes
            // 
            this.listClothes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.listClothes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listClothes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listClothes.FormattingEnabled = true;
            this.listClothes.ItemHeight = 25;
            this.listClothes.Location = new System.Drawing.Point(12, 47);
            this.listClothes.Name = "listClothes";
            this.listClothes.Size = new System.Drawing.Size(164, 150);
            this.listClothes.TabIndex = 14;
            this.listClothes.SelectedIndexChanged += new System.EventHandler(this.listClothes_SelectedIndexChanged);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(196, 49);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(103, 30);
            this.lblLocation.TabIndex = 15;
            this.lblLocation.Text = "Location :";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(196, 105);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(69, 30);
            this.lblPrice.TabIndex = 16;
            this.lblPrice.Text = "Price :";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(196, 167);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(104, 30);
            this.lblQty.TabIndex = 17;
            this.lblQty.Text = "Quantity :";
            // 
            // lblLocationValue
            // 
            this.lblLocationValue.AutoSize = true;
            this.lblLocationValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationValue.Location = new System.Drawing.Point(360, 49);
            this.lblLocationValue.Name = "lblLocationValue";
            this.lblLocationValue.Size = new System.Drawing.Size(104, 30);
            this.lblLocationValue.TabIndex = 18;
            this.lblLocationValue.Text = "[Location]";
            // 
            // lblPriceValue
            // 
            this.lblPriceValue.AutoSize = true;
            this.lblPriceValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceValue.Location = new System.Drawing.Point(360, 105);
            this.lblPriceValue.Name = "lblPriceValue";
            this.lblPriceValue.Size = new System.Drawing.Size(70, 30);
            this.lblPriceValue.TabIndex = 19;
            this.lblPriceValue.Text = "[Price]";
            // 
            // lblQtyValue
            // 
            this.lblQtyValue.AutoSize = true;
            this.lblQtyValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtyValue.Location = new System.Drawing.Point(360, 167);
            this.lblQtyValue.Name = "lblQtyValue";
            this.lblQtyValue.Size = new System.Drawing.Size(105, 30);
            this.lblQtyValue.TabIndex = 20;
            this.lblQtyValue.Text = "[Quantity]";
            // 
            // infoLogo
            // 
            this.infoLogo.BackgroundImage = global::KinectFit.Properties.Resources.small_kinect;
            this.infoLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.infoLogo.Location = new System.Drawing.Point(718, 2);
            this.infoLogo.Name = "infoLogo";
            this.infoLogo.Size = new System.Drawing.Size(63, 65);
            this.infoLogo.TabIndex = 12;
            this.infoLogo.TabStop = false;
            // 
            // lblConnection
            // 
            this.lblConnection.AutoSize = true;
            this.lblConnection.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnection.Location = new System.Drawing.Point(586, 180);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(195, 21);
            this.lblConnection.TabIndex = 22;
            this.lblConnection.Text = "Not connected to database";
            // 
            // connectionPicture
            // 
            this.connectionPicture.BackgroundImage = global::KinectFit.Properties.Resources.offline;
            this.connectionPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.connectionPicture.Location = new System.Drawing.Point(718, 112);
            this.connectionPicture.Name = "connectionPicture";
            this.connectionPicture.Size = new System.Drawing.Size(63, 65);
            this.connectionPicture.TabIndex = 21;
            this.connectionPicture.TabStop = false;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(793, 262);
            this.Controls.Add(this.lblConnection);
            this.Controls.Add(this.connectionPicture);
            this.Controls.Add(this.lblQtyValue);
            this.Controls.Add(this.lblPriceValue);
            this.Controls.Add(this.lblLocationValue);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.listClothes);
            this.Controls.Add(this.lblInfo1);
            this.Controls.Add(this.infoLogo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFinished;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblInfo1;
        private System.Windows.Forms.PictureBox infoLogo;
        private System.Windows.Forms.ListBox listClothes;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblLocationValue;
        private System.Windows.Forms.Label lblPriceValue;
        private System.Windows.Forms.Label lblQtyValue;
        private System.Windows.Forms.Label lblConnection;
        private System.Windows.Forms.PictureBox connectionPicture;
    }
}