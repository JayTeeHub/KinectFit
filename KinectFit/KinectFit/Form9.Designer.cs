namespace KinectFit
{
    partial class Form9
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
            this.lblQtyValue = new System.Windows.Forms.Label();
            this.lblPriceValue = new System.Windows.Forms.Label();
            this.lblLocationValue = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.listBrands = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnFinished = new System.Windows.Forms.Button();
            this.infoLogo = new System.Windows.Forms.PictureBox();
            this.listClothes = new System.Windows.Forms.ListBox();
            this.lblBrands = new System.Windows.Forms.Label();
            this.lblProducts = new System.Windows.Forms.Label();
            this.connectionPicture = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQtyValue
            // 
            this.lblQtyValue.AutoSize = true;
            this.lblQtyValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtyValue.Location = new System.Drawing.Point(542, 161);
            this.lblQtyValue.Name = "lblQtyValue";
            this.lblQtyValue.Size = new System.Drawing.Size(105, 30);
            this.lblQtyValue.TabIndex = 29;
            this.lblQtyValue.Text = "[Quantity]";
            // 
            // lblPriceValue
            // 
            this.lblPriceValue.AutoSize = true;
            this.lblPriceValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceValue.Location = new System.Drawing.Point(542, 99);
            this.lblPriceValue.Name = "lblPriceValue";
            this.lblPriceValue.Size = new System.Drawing.Size(70, 30);
            this.lblPriceValue.TabIndex = 28;
            this.lblPriceValue.Text = "[Price]";
            // 
            // lblLocationValue
            // 
            this.lblLocationValue.AutoSize = true;
            this.lblLocationValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationValue.Location = new System.Drawing.Point(542, 43);
            this.lblLocationValue.Name = "lblLocationValue";
            this.lblLocationValue.Size = new System.Drawing.Size(104, 30);
            this.lblLocationValue.TabIndex = 27;
            this.lblLocationValue.Text = "[Location]";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(378, 161);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(104, 30);
            this.lblQty.TabIndex = 26;
            this.lblQty.Text = "Quantity :";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(378, 99);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(69, 30);
            this.lblPrice.TabIndex = 25;
            this.lblPrice.Text = "Price :";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(378, 43);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(103, 30);
            this.lblLocation.TabIndex = 24;
            this.lblLocation.Text = "Location :";
            // 
            // listBrands
            // 
            this.listBrands.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.listBrands.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBrands.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBrands.FormattingEnabled = true;
            this.listBrands.ItemHeight = 25;
            this.listBrands.Location = new System.Drawing.Point(12, 46);
            this.listBrands.Name = "listBrands";
            this.listBrands.Size = new System.Drawing.Size(164, 150);
            this.listBrands.TabIndex = 23;
            this.listBrands.SelectedIndexChanged += new System.EventHandler(this.listBrands_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnFinished);
            this.panel1.Location = new System.Drawing.Point(0, 203);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 58);
            this.panel1.TabIndex = 21;
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(238, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 46);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseEnter += new System.EventHandler(this.btnBack_MouseEnter);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
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
            // infoLogo
            // 
            this.infoLogo.BackgroundImage = global::KinectFit.Properties.Resources.small_kinect;
            this.infoLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.infoLogo.Location = new System.Drawing.Point(718, 1);
            this.infoLogo.Name = "infoLogo";
            this.infoLogo.Size = new System.Drawing.Size(63, 65);
            this.infoLogo.TabIndex = 22;
            this.infoLogo.TabStop = false;
            // 
            // listClothes
            // 
            this.listClothes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.listClothes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listClothes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listClothes.FormattingEnabled = true;
            this.listClothes.ItemHeight = 25;
            this.listClothes.Location = new System.Drawing.Point(194, 45);
            this.listClothes.Name = "listClothes";
            this.listClothes.Size = new System.Drawing.Size(178, 150);
            this.listClothes.TabIndex = 30;
            this.listClothes.SelectedIndexChanged += new System.EventHandler(this.listClothes_SelectedIndexChanged);
            // 
            // lblBrands
            // 
            this.lblBrands.AutoSize = true;
            this.lblBrands.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrands.Location = new System.Drawing.Point(38, 9);
            this.lblBrands.Name = "lblBrands";
            this.lblBrands.Size = new System.Drawing.Size(76, 30);
            this.lblBrands.TabIndex = 31;
            this.lblBrands.Text = "Brands";
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducts.Location = new System.Drawing.Point(231, 9);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(94, 30);
            this.lblProducts.TabIndex = 32;
            this.lblProducts.Text = "Products";
            // 
            // connectionPicture
            // 
            this.connectionPicture.BackgroundImage = global::KinectFit.Properties.Resources.offline;
            this.connectionPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.connectionPicture.Location = new System.Drawing.Point(718, 126);
            this.connectionPicture.Name = "connectionPicture";
            this.connectionPicture.Size = new System.Drawing.Size(63, 65);
            this.connectionPicture.TabIndex = 33;
            this.connectionPicture.TabStop = false;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(793, 262);
            this.Controls.Add(this.connectionPicture);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.lblBrands);
            this.Controls.Add(this.listClothes);
            this.Controls.Add(this.lblQtyValue);
            this.Controls.Add(this.lblPriceValue);
            this.Controls.Add(this.lblLocationValue);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.listBrands);
            this.Controls.Add(this.infoLogo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.infoLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQtyValue;
        private System.Windows.Forms.Label lblPriceValue;
        private System.Windows.Forms.Label lblLocationValue;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.ListBox listBrands;
        private System.Windows.Forms.PictureBox infoLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFinished;
        private System.Windows.Forms.ListBox listClothes;
        private System.Windows.Forms.Label lblBrands;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox connectionPicture;
    }
}