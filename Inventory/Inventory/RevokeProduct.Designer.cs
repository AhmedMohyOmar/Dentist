namespace Inventory
{
    partial class RevokeProduct
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
            this.NewProductPanel = new System.Windows.Forms.Panel();
            this.ErrorLbl = new System.Windows.Forms.Label();
            this.ProductNameCB = new System.Windows.Forms.ComboBox();
            this.ProductNameLbl = new System.Windows.Forms.Label();
            this.RevokeProductBtn = new System.Windows.Forms.Button();
            this.ProductQuantityTxt = new System.Windows.Forms.TextBox();
            this.ProductQuantityLbl = new System.Windows.Forms.Label();
            this.RevokeProductLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.ProjectName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NewProductPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NewProductPanel
            // 
            this.NewProductPanel.Controls.Add(this.ErrorLbl);
            this.NewProductPanel.Controls.Add(this.ProductNameCB);
            this.NewProductPanel.Controls.Add(this.ProductNameLbl);
            this.NewProductPanel.Controls.Add(this.RevokeProductBtn);
            this.NewProductPanel.Controls.Add(this.ProductQuantityTxt);
            this.NewProductPanel.Controls.Add(this.ProductQuantityLbl);
            this.NewProductPanel.Location = new System.Drawing.Point(74, 122);
            this.NewProductPanel.Name = "NewProductPanel";
            this.NewProductPanel.Size = new System.Drawing.Size(287, 147);
            this.NewProductPanel.TabIndex = 18;
            // 
            // ErrorLbl
            // 
            this.ErrorLbl.AutoSize = true;
            this.ErrorLbl.ForeColor = System.Drawing.Color.Black;
            this.ErrorLbl.Location = new System.Drawing.Point(78, 127);
            this.ErrorLbl.Name = "ErrorLbl";
            this.ErrorLbl.Size = new System.Drawing.Size(131, 13);
            this.ErrorLbl.TabIndex = 15;
            this.ErrorLbl.Text = "Please fill all data correctly";
            this.ErrorLbl.Visible = false;
            // 
            // ProductNameCB
            // 
            this.ProductNameCB.FormattingEnabled = true;
            this.ProductNameCB.Location = new System.Drawing.Point(76, 2);
            this.ProductNameCB.Name = "ProductNameCB";
            this.ProductNameCB.Size = new System.Drawing.Size(206, 21);
            this.ProductNameCB.TabIndex = 10;
            // 
            // ProductNameLbl
            // 
            this.ProductNameLbl.AutoSize = true;
            this.ProductNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ProductNameLbl.Location = new System.Drawing.Point(3, 2);
            this.ProductNameLbl.Name = "ProductNameLbl";
            this.ProductNameLbl.Size = new System.Drawing.Size(51, 20);
            this.ProductNameLbl.TabIndex = 0;
            this.ProductNameLbl.Text = "Name";
            // 
            // RevokeProductBtn
            // 
            this.RevokeProductBtn.BackColor = System.Drawing.Color.Sienna;
            this.RevokeProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RevokeProductBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RevokeProductBtn.ForeColor = System.Drawing.Color.Tan;
            this.RevokeProductBtn.Location = new System.Drawing.Point(7, 89);
            this.RevokeProductBtn.Name = "RevokeProductBtn";
            this.RevokeProductBtn.Size = new System.Drawing.Size(274, 31);
            this.RevokeProductBtn.TabIndex = 8;
            this.RevokeProductBtn.Text = "Done";
            this.RevokeProductBtn.UseVisualStyleBackColor = false;
            this.RevokeProductBtn.Click += new System.EventHandler(this.RevokeProductBtn_Click);
            // 
            // ProductQuantityTxt
            // 
            this.ProductQuantityTxt.Location = new System.Drawing.Point(76, 39);
            this.ProductQuantityTxt.Multiline = true;
            this.ProductQuantityTxt.Name = "ProductQuantityTxt";
            this.ProductQuantityTxt.Size = new System.Drawing.Size(205, 26);
            this.ProductQuantityTxt.TabIndex = 7;
            this.ProductQuantityTxt.TextChanged += new System.EventHandler(this.ProductQuantityTxt_TextChanged);
            // 
            // ProductQuantityLbl
            // 
            this.ProductQuantityLbl.AutoSize = true;
            this.ProductQuantityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductQuantityLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ProductQuantityLbl.Location = new System.Drawing.Point(3, 42);
            this.ProductQuantityLbl.Name = "ProductQuantityLbl";
            this.ProductQuantityLbl.Size = new System.Drawing.Size(68, 20);
            this.ProductQuantityLbl.TabIndex = 3;
            this.ProductQuantityLbl.Text = "Quantity";
            // 
            // RevokeProductLbl
            // 
            this.RevokeProductLbl.AutoSize = true;
            this.RevokeProductLbl.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RevokeProductLbl.Location = new System.Drawing.Point(144, 79);
            this.RevokeProductLbl.Name = "RevokeProductLbl";
            this.RevokeProductLbl.Size = new System.Drawing.Size(168, 25);
            this.RevokeProductLbl.TabIndex = 17;
            this.RevokeProductLbl.Text = "Revoke Product";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Sienna;
            this.panel1.Controls.Add(this.HomeBtn);
            this.panel1.Controls.Add(this.ProjectName);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 66);
            this.panel1.TabIndex = 16;
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.Color.Sienna;
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.ForeColor = System.Drawing.Color.Tan;
            this.HomeBtn.Location = new System.Drawing.Point(382, -1);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(46, 23);
            this.HomeBtn.TabIndex = 19;
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
            // RevokeProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(449, 342);
            this.Controls.Add(this.NewProductPanel);
            this.Controls.Add(this.RevokeProductLbl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RevokeProduct";
            this.Text = "RevokeProduct";
            this.NewProductPanel.ResumeLayout(false);
            this.NewProductPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel NewProductPanel;
        private System.Windows.Forms.Label ProductNameLbl;
        private System.Windows.Forms.Button RevokeProductBtn;
        private System.Windows.Forms.TextBox ProductQuantityTxt;
        private System.Windows.Forms.Label ProductQuantityLbl;
        private System.Windows.Forms.Label RevokeProductLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ProjectName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox ProductNameCB;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Label ErrorLbl;
    }
}