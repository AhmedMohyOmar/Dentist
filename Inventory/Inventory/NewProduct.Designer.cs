namespace Inventory
{
    partial class NewProduct
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
            this.HomeBtn = new System.Windows.Forms.Button();
            this.ProjectName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NewProductPanel = new System.Windows.Forms.Panel();
            this.ProductNameENTxt = new System.Windows.Forms.TextBox();
            this.ProductNameENLbl = new System.Windows.Forms.Label();
            this.ProductCodeTxt = new System.Windows.Forms.TextBox();
            this.ProductCodeLbl = new System.Windows.Forms.Label();
            this.ProductNameARLbl = new System.Windows.Forms.Label();
            this.NewProductBtn = new System.Windows.Forms.Button();
            this.ProductColorLbl = new System.Windows.Forms.Label();
            this.ProductQuantityTxt = new System.Windows.Forms.TextBox();
            this.ProductPriceLbl = new System.Windows.Forms.Label();
            this.ProductPriceTxt = new System.Windows.Forms.TextBox();
            this.ProductQuantityLbl = new System.Windows.Forms.Label();
            this.ProductColorTxt = new System.Windows.Forms.TextBox();
            this.ProductNameARTxt = new System.Windows.Forms.TextBox();
            this.NewProductLbl = new System.Windows.Forms.Label();
            this.ErrorLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.NewProductPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Sienna;
            this.panel1.Controls.Add(this.HomeBtn);
            this.panel1.Controls.Add(this.ProjectName);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 66);
            this.panel1.TabIndex = 1;
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.Color.Sienna;
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.ForeColor = System.Drawing.Color.Tan;
            this.HomeBtn.Location = new System.Drawing.Point(382, -1);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(46, 23);
            this.HomeBtn.TabIndex = 9;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.UseVisualStyleBackColor = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // ProjectName
            // 
            this.ProjectName.AutoSize = true;
            this.ProjectName.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ProjectName.Location = new System.Drawing.Point(86, 22);
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.Size = new System.Drawing.Size(219, 23);
            this.ProjectName.TabIndex = 2;
            this.ProjectName.Text = "Inventory System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Inventory.Properties.Resources.inventory__1_;
            this.pictureBox1.Location = new System.Drawing.Point(14, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // NewProductPanel
            // 
            this.NewProductPanel.Controls.Add(this.ErrorLbl);
            this.NewProductPanel.Controls.Add(this.ProductNameENTxt);
            this.NewProductPanel.Controls.Add(this.ProductNameENLbl);
            this.NewProductPanel.Controls.Add(this.ProductCodeTxt);
            this.NewProductPanel.Controls.Add(this.ProductCodeLbl);
            this.NewProductPanel.Controls.Add(this.ProductNameARLbl);
            this.NewProductPanel.Controls.Add(this.NewProductBtn);
            this.NewProductPanel.Controls.Add(this.ProductColorLbl);
            this.NewProductPanel.Controls.Add(this.ProductQuantityTxt);
            this.NewProductPanel.Controls.Add(this.ProductPriceLbl);
            this.NewProductPanel.Controls.Add(this.ProductPriceTxt);
            this.NewProductPanel.Controls.Add(this.ProductQuantityLbl);
            this.NewProductPanel.Controls.Add(this.ProductColorTxt);
            this.NewProductPanel.Controls.Add(this.ProductNameARTxt);
            this.NewProductPanel.Location = new System.Drawing.Point(81, 117);
            this.NewProductPanel.Name = "NewProductPanel";
            this.NewProductPanel.Size = new System.Drawing.Size(296, 251);
            this.NewProductPanel.TabIndex = 10;
            // 
            // ProductNameENTxt
            // 
            this.ProductNameENTxt.Location = new System.Drawing.Point(86, 32);
            this.ProductNameENTxt.Multiline = true;
            this.ProductNameENTxt.Name = "ProductNameENTxt";
            this.ProductNameENTxt.Size = new System.Drawing.Size(205, 26);
            this.ProductNameENTxt.TabIndex = 12;
            this.ProductNameENTxt.TextChanged += new System.EventHandler(this.ProductNameENTxt_TextChanged);
            // 
            // ProductNameENLbl
            // 
            this.ProductNameENLbl.AutoSize = true;
            this.ProductNameENLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameENLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ProductNameENLbl.Location = new System.Drawing.Point(3, 32);
            this.ProductNameENLbl.Name = "ProductNameENLbl";
            this.ProductNameENLbl.Size = new System.Drawing.Size(77, 20);
            this.ProductNameENLbl.TabIndex = 11;
            this.ProductNameENLbl.Text = "Name EN";
            // 
            // ProductCodeTxt
            // 
            this.ProductCodeTxt.Location = new System.Drawing.Point(86, 160);
            this.ProductCodeTxt.Multiline = true;
            this.ProductCodeTxt.Name = "ProductCodeTxt";
            this.ProductCodeTxt.Size = new System.Drawing.Size(205, 26);
            this.ProductCodeTxt.TabIndex = 10;
            this.ProductCodeTxt.TextChanged += new System.EventHandler(this.ProductCodeTxt_TextChanged);
            // 
            // ProductCodeLbl
            // 
            this.ProductCodeLbl.AutoSize = true;
            this.ProductCodeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductCodeLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ProductCodeLbl.Location = new System.Drawing.Point(3, 160);
            this.ProductCodeLbl.Name = "ProductCodeLbl";
            this.ProductCodeLbl.Size = new System.Drawing.Size(47, 20);
            this.ProductCodeLbl.TabIndex = 9;
            this.ProductCodeLbl.Text = "Code";
            // 
            // ProductNameARLbl
            // 
            this.ProductNameARLbl.AutoSize = true;
            this.ProductNameARLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameARLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ProductNameARLbl.Location = new System.Drawing.Point(3, 2);
            this.ProductNameARLbl.Name = "ProductNameARLbl";
            this.ProductNameARLbl.Size = new System.Drawing.Size(78, 20);
            this.ProductNameARLbl.TabIndex = 0;
            this.ProductNameARLbl.Text = "Name AR";
            // 
            // NewProductBtn
            // 
            this.NewProductBtn.BackColor = System.Drawing.Color.Sienna;
            this.NewProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewProductBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewProductBtn.ForeColor = System.Drawing.Color.Tan;
            this.NewProductBtn.Location = new System.Drawing.Point(9, 192);
            this.NewProductBtn.Name = "NewProductBtn";
            this.NewProductBtn.Size = new System.Drawing.Size(282, 31);
            this.NewProductBtn.TabIndex = 8;
            this.NewProductBtn.Text = "Done";
            this.NewProductBtn.UseVisualStyleBackColor = false;
            this.NewProductBtn.Click += new System.EventHandler(this.NewProductBtn_Click);
            // 
            // ProductColorLbl
            // 
            this.ProductColorLbl.AutoSize = true;
            this.ProductColorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductColorLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ProductColorLbl.Location = new System.Drawing.Point(3, 64);
            this.ProductColorLbl.Name = "ProductColorLbl";
            this.ProductColorLbl.Size = new System.Drawing.Size(46, 20);
            this.ProductColorLbl.TabIndex = 1;
            this.ProductColorLbl.Text = "Color";
            // 
            // ProductQuantityTxt
            // 
            this.ProductQuantityTxt.Location = new System.Drawing.Point(86, 128);
            this.ProductQuantityTxt.Multiline = true;
            this.ProductQuantityTxt.Name = "ProductQuantityTxt";
            this.ProductQuantityTxt.Size = new System.Drawing.Size(205, 26);
            this.ProductQuantityTxt.TabIndex = 7;
            this.ProductQuantityTxt.TextChanged += new System.EventHandler(this.ProductQuantityTxt_TextChanged);
            // 
            // ProductPriceLbl
            // 
            this.ProductPriceLbl.AutoSize = true;
            this.ProductPriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductPriceLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ProductPriceLbl.Location = new System.Drawing.Point(5, 96);
            this.ProductPriceLbl.Name = "ProductPriceLbl";
            this.ProductPriceLbl.Size = new System.Drawing.Size(44, 20);
            this.ProductPriceLbl.TabIndex = 2;
            this.ProductPriceLbl.Text = "Price";
            // 
            // ProductPriceTxt
            // 
            this.ProductPriceTxt.Location = new System.Drawing.Point(86, 96);
            this.ProductPriceTxt.Multiline = true;
            this.ProductPriceTxt.Name = "ProductPriceTxt";
            this.ProductPriceTxt.Size = new System.Drawing.Size(205, 26);
            this.ProductPriceTxt.TabIndex = 6;
            this.ProductPriceTxt.TextChanged += new System.EventHandler(this.ProductPriceTxt_TextChanged);
            // 
            // ProductQuantityLbl
            // 
            this.ProductQuantityLbl.AutoSize = true;
            this.ProductQuantityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductQuantityLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ProductQuantityLbl.Location = new System.Drawing.Point(3, 128);
            this.ProductQuantityLbl.Name = "ProductQuantityLbl";
            this.ProductQuantityLbl.Size = new System.Drawing.Size(68, 20);
            this.ProductQuantityLbl.TabIndex = 3;
            this.ProductQuantityLbl.Text = "Quantity";
            // 
            // ProductColorTxt
            // 
            this.ProductColorTxt.Location = new System.Drawing.Point(86, 64);
            this.ProductColorTxt.Multiline = true;
            this.ProductColorTxt.Name = "ProductColorTxt";
            this.ProductColorTxt.Size = new System.Drawing.Size(205, 26);
            this.ProductColorTxt.TabIndex = 5;
            this.ProductColorTxt.TextChanged += new System.EventHandler(this.ProductColorTxt_TextChanged);
            // 
            // ProductNameARTxt
            // 
            this.ProductNameARTxt.Location = new System.Drawing.Point(86, 0);
            this.ProductNameARTxt.Multiline = true;
            this.ProductNameARTxt.Name = "ProductNameARTxt";
            this.ProductNameARTxt.Size = new System.Drawing.Size(205, 26);
            this.ProductNameARTxt.TabIndex = 4;
            this.ProductNameARTxt.TextChanged += new System.EventHandler(this.ProductNameARTxt_TextChanged);
            // 
            // NewProductLbl
            // 
            this.NewProductLbl.AutoSize = true;
            this.NewProductLbl.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewProductLbl.Location = new System.Drawing.Point(152, 79);
            this.NewProductLbl.Name = "NewProductLbl";
            this.NewProductLbl.Size = new System.Drawing.Size(140, 25);
            this.NewProductLbl.TabIndex = 11;
            this.NewProductLbl.Text = "New Product";
            // 
            // ErrorLbl
            // 
            this.ErrorLbl.AutoSize = true;
            this.ErrorLbl.ForeColor = System.Drawing.Color.Black;
            this.ErrorLbl.Location = new System.Drawing.Point(77, 230);
            this.ErrorLbl.Name = "ErrorLbl";
            this.ErrorLbl.Size = new System.Drawing.Size(131, 13);
            this.ErrorLbl.TabIndex = 13;
            this.ErrorLbl.Text = "Please fill all data correctly";
            this.ErrorLbl.Visible = false;
            // 
            // NewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(449, 380);
            this.Controls.Add(this.NewProductLbl);
            this.Controls.Add(this.NewProductPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewProduct";
            this.Text = "NewProduct";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.NewProductPanel.ResumeLayout(false);
            this.NewProductPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ProjectName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel NewProductPanel;
        private System.Windows.Forms.Label ProductNameARLbl;
        private System.Windows.Forms.Button NewProductBtn;
        private System.Windows.Forms.Label ProductColorLbl;
        private System.Windows.Forms.TextBox ProductQuantityTxt;
        private System.Windows.Forms.Label ProductPriceLbl;
        private System.Windows.Forms.TextBox ProductPriceTxt;
        private System.Windows.Forms.Label ProductQuantityLbl;
        private System.Windows.Forms.TextBox ProductColorTxt;
        private System.Windows.Forms.TextBox ProductNameARTxt;
        private System.Windows.Forms.Label NewProductLbl;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.TextBox ProductNameENTxt;
        private System.Windows.Forms.Label ProductNameENLbl;
        private System.Windows.Forms.TextBox ProductCodeTxt;
        private System.Windows.Forms.Label ProductCodeLbl;
        private System.Windows.Forms.Label ErrorLbl;
    }
}