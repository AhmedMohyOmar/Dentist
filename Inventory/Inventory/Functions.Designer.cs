namespace Inventory
{
    partial class Functions
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
            this.ProjectName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ViewCashTab = new System.Windows.Forms.Button();
            this.RevokeProductTab = new System.Windows.Forms.Button();
            this.ViewProductsTab = new System.Windows.Forms.Button();
            this.AddProductTab = new System.Windows.Forms.Button();
            this.NewProductTab = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Sienna;
            this.panel1.Controls.Add(this.ProjectName);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 66);
            this.panel1.TabIndex = 0;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.ViewCashTab);
            this.panel2.Controls.Add(this.RevokeProductTab);
            this.panel2.Controls.Add(this.ViewProductsTab);
            this.panel2.Controls.Add(this.AddProductTab);
            this.panel2.Controls.Add(this.NewProductTab);
            this.panel2.Location = new System.Drawing.Point(-1, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 237);
            this.panel2.TabIndex = 1;
            // 
            // ViewCashTab
            // 
            this.ViewCashTab.BackColor = System.Drawing.Color.Sienna;
            this.ViewCashTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewCashTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewCashTab.ForeColor = System.Drawing.Color.Tan;
            this.ViewCashTab.Location = new System.Drawing.Point(47, 161);
            this.ViewCashTab.Name = "ViewCashTab";
            this.ViewCashTab.Size = new System.Drawing.Size(210, 32);
            this.ViewCashTab.TabIndex = 4;
            this.ViewCashTab.Text = "View Cash";
            this.ViewCashTab.UseVisualStyleBackColor = false;
            this.ViewCashTab.Click += new System.EventHandler(this.ViewCashTab_Click);
            // 
            // RevokeProductTab
            // 
            this.RevokeProductTab.BackColor = System.Drawing.Color.Sienna;
            this.RevokeProductTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RevokeProductTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RevokeProductTab.ForeColor = System.Drawing.Color.Tan;
            this.RevokeProductTab.Location = new System.Drawing.Point(47, 85);
            this.RevokeProductTab.Name = "RevokeProductTab";
            this.RevokeProductTab.Size = new System.Drawing.Size(210, 32);
            this.RevokeProductTab.TabIndex = 3;
            this.RevokeProductTab.Text = "Revoke Product";
            this.RevokeProductTab.UseVisualStyleBackColor = false;
            this.RevokeProductTab.Click += new System.EventHandler(this.RevokeProductTab_Click);
            // 
            // ViewProductsTab
            // 
            this.ViewProductsTab.BackColor = System.Drawing.Color.Sienna;
            this.ViewProductsTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewProductsTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewProductsTab.ForeColor = System.Drawing.Color.Tan;
            this.ViewProductsTab.Location = new System.Drawing.Point(47, 123);
            this.ViewProductsTab.Name = "ViewProductsTab";
            this.ViewProductsTab.Size = new System.Drawing.Size(210, 32);
            this.ViewProductsTab.TabIndex = 2;
            this.ViewProductsTab.Text = "View Products";
            this.ViewProductsTab.UseVisualStyleBackColor = false;
            this.ViewProductsTab.Click += new System.EventHandler(this.ViewProductsTab_Click);
            // 
            // AddProductTab
            // 
            this.AddProductTab.BackColor = System.Drawing.Color.Sienna;
            this.AddProductTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddProductTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductTab.ForeColor = System.Drawing.Color.Tan;
            this.AddProductTab.Location = new System.Drawing.Point(47, 47);
            this.AddProductTab.Name = "AddProductTab";
            this.AddProductTab.Size = new System.Drawing.Size(210, 32);
            this.AddProductTab.TabIndex = 1;
            this.AddProductTab.Text = "Add Product";
            this.AddProductTab.UseVisualStyleBackColor = false;
            this.AddProductTab.Click += new System.EventHandler(this.AddProductTab_Click);
            // 
            // NewProductTab
            // 
            this.NewProductTab.BackColor = System.Drawing.Color.Sienna;
            this.NewProductTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewProductTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewProductTab.ForeColor = System.Drawing.Color.Tan;
            this.NewProductTab.Location = new System.Drawing.Point(47, 9);
            this.NewProductTab.Name = "NewProductTab";
            this.NewProductTab.Size = new System.Drawing.Size(210, 32);
            this.NewProductTab.TabIndex = 0;
            this.NewProductTab.Text = "New Product";
            this.NewProductTab.UseVisualStyleBackColor = false;
            this.NewProductTab.Click += new System.EventHandler(this.NewProductTab_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.Color.Sienna;
            this.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.ForeColor = System.Drawing.Color.Tan;
            this.LogoutBtn.Location = new System.Drawing.Point(46, 267);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(210, 32);
            this.LogoutBtn.TabIndex = 5;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = false;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // Functions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(312, 317);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Functions";
            this.Text = "Functions";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ProjectName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AddProductTab;
        private System.Windows.Forms.Button NewProductTab;
        private System.Windows.Forms.Button ViewProductsTab;
        private System.Windows.Forms.Button ViewCashTab;
        private System.Windows.Forms.Button RevokeProductTab;
        private System.Windows.Forms.Button LogoutBtn;
    }
}