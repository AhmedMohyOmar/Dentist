namespace Inventory
{
    partial class ViewCash
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.DoneBtn = new System.Windows.Forms.Button();
            this.ToDT = new System.Windows.Forms.DateTimePicker();
            this.FromDT = new System.Windows.Forms.DateTimePicker();
            this.ToLbl = new System.Windows.Forms.Label();
            this.FromLbl = new System.Windows.Forms.Label();
            this.ViewCashDGV = new System.Windows.Forms.DataGridView();
            this.ViewCashLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.ProjectName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewCashDGV)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.DoneBtn);
            this.panel4.Controls.Add(this.ToDT);
            this.panel4.Controls.Add(this.FromDT);
            this.panel4.Controls.Add(this.ToLbl);
            this.panel4.Controls.Add(this.FromLbl);
            this.panel4.Controls.Add(this.ViewCashDGV);
            this.panel4.Location = new System.Drawing.Point(12, 107);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(425, 223);
            this.panel4.TabIndex = 16;
            // 
            // DoneBtn
            // 
            this.DoneBtn.BackColor = System.Drawing.Color.Sienna;
            this.DoneBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoneBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoneBtn.ForeColor = System.Drawing.Color.Tan;
            this.DoneBtn.Location = new System.Drawing.Point(327, 16);
            this.DoneBtn.Name = "DoneBtn";
            this.DoneBtn.Size = new System.Drawing.Size(78, 28);
            this.DoneBtn.TabIndex = 9;
            this.DoneBtn.Text = "Done";
            this.DoneBtn.UseVisualStyleBackColor = false;
            // 
            // ToDT
            // 
            this.ToDT.Location = new System.Drawing.Point(217, 20);
            this.ToDT.Name = "ToDT";
            this.ToDT.Size = new System.Drawing.Size(104, 20);
            this.ToDT.TabIndex = 4;
            // 
            // FromDT
            // 
            this.FromDT.Location = new System.Drawing.Point(69, 20);
            this.FromDT.Name = "FromDT";
            this.FromDT.Size = new System.Drawing.Size(105, 20);
            this.FromDT.TabIndex = 3;
            // 
            // ToLbl
            // 
            this.ToLbl.AutoSize = true;
            this.ToLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ToLbl.Location = new System.Drawing.Point(184, 19);
            this.ToLbl.Name = "ToLbl";
            this.ToLbl.Size = new System.Drawing.Size(27, 20);
            this.ToLbl.TabIndex = 2;
            this.ToLbl.Text = "To";
            // 
            // FromLbl
            // 
            this.FromLbl.AutoSize = true;
            this.FromLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FromLbl.Location = new System.Drawing.Point(17, 20);
            this.FromLbl.Name = "FromLbl";
            this.FromLbl.Size = new System.Drawing.Size(46, 20);
            this.FromLbl.TabIndex = 1;
            this.FromLbl.Text = "From";
            // 
            // ViewCashDGV
            // 
            this.ViewCashDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewCashDGV.Location = new System.Drawing.Point(0, 59);
            this.ViewCashDGV.Name = "ViewCashDGV";
            this.ViewCashDGV.Size = new System.Drawing.Size(425, 164);
            this.ViewCashDGV.TabIndex = 0;
            // 
            // ViewCashLbl
            // 
            this.ViewCashLbl.AutoSize = true;
            this.ViewCashLbl.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewCashLbl.Location = new System.Drawing.Point(144, 79);
            this.ViewCashLbl.Name = "ViewCashLbl";
            this.ViewCashLbl.Size = new System.Drawing.Size(114, 25);
            this.ViewCashLbl.TabIndex = 15;
            this.ViewCashLbl.Text = "View Cash";
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
            this.panel1.TabIndex = 14;
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.Color.Sienna;
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBtn.ForeColor = System.Drawing.Color.Tan;
            this.HomeBtn.Location = new System.Drawing.Point(382, -1);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(46, 23);
            this.HomeBtn.TabIndex = 10;
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
            // ViewCash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(449, 342);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.ViewCashLbl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewCash";
            this.Text = "ViewCash";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewCashDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button DoneBtn;
        private System.Windows.Forms.DateTimePicker ToDT;
        private System.Windows.Forms.DateTimePicker FromDT;
        private System.Windows.Forms.Label ToLbl;
        private System.Windows.Forms.Label FromLbl;
        private System.Windows.Forms.DataGridView ViewCashDGV;
        private System.Windows.Forms.Label ViewCashLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ProjectName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button HomeBtn;
    }
}