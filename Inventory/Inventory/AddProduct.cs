using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
            FillNames();
        }

        public void FillNames()
        {
            ProductNameCB.DisplayMember = "ProductName_en";
            ProductNameCB.ValueMember = "Code";
            ProductNameCB.DataSource = Validations.SelectAllProducts();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            int quantity;
            if (int.TryParse(ProductQuantityTxt.Text, out quantity))
            {
                if (Validations.AddQuantity(quantity, ProductNameCB.SelectedValue.ToString()))
                {
                    MessageBox.Show("Product Quantity Modified Successfully");
                    ProductQuantityTxt.Text = "";
                }
                else
                {
                    MessageBox.Show("Something Went Wrong");
                }
            }
            else
            {
                ErrorLbl.Visible = true;
            }
        }

        private void ProductQuantityTxt_TextChanged(object sender, EventArgs e)
        {
            ErrorLbl.Visible = false;
        }
    }
}
