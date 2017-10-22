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
    public partial class NewProduct : Form
    {
        public NewProduct()
        {
            InitializeComponent();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewProductBtn_Click(object sender, EventArgs e)
        {
            float price;
            int quantity;
            if (ProductNameENTxt.Text == "" || ProductNameARTxt.Text == "" || ProductPriceTxt.Text == "" || ProductCodeTxt.Text == "" || ProductQuantityTxt.Text == "")
            {
                ErrorLbl.Visible = true;
            }
            else if (float.TryParse(ProductPriceTxt.Text,out price) && int.TryParse(ProductQuantityTxt.Text, out quantity))
            {
                Product NewProduct = new Product ();
                NewProduct.ProductName_en = ProductNameENTxt.Text;
                NewProduct.ProductName_ar = ProductNameARTxt.Text;
                NewProduct.Code = ProductCodeTxt.Text;
                NewProduct.Color = ProductColorTxt.Text;
                NewProduct.Price = price;
                NewProduct.Qty = quantity;
                NewProduct.Date_Entry = DateTime.Now;

                if (Validations.AddNewProduct(NewProduct))
                {
                    MessageBox.Show("Product added successfully");
                    ProductCodeTxt.Text = ProductColorTxt.Text = ProductNameARTxt.Text = ProductNameENTxt.Text = ProductPriceTxt.Text = ProductQuantityTxt.Text = "";
                }
                else
                {
                    MessageBox.Show("Something went wrong");
                }          
            }
            else
            {
                ErrorLbl.Visible = true;
            }
        }

        private void ProductNameARTxt_TextChanged(object sender, EventArgs e)
        {
            ErrorLbl.Visible = false;
        }

        private void ProductNameENTxt_TextChanged(object sender, EventArgs e)
        {
            ErrorLbl.Visible = false;
        }

        private void ProductColorTxt_TextChanged(object sender, EventArgs e)
        {
            ErrorLbl.Visible = false;
        }

        private void ProductPriceTxt_TextChanged(object sender, EventArgs e)
        {
            ErrorLbl.Visible = false;
        }

        private void ProductQuantityTxt_TextChanged(object sender, EventArgs e)
        {
            ErrorLbl.Visible = false;
        }

        private void ProductCodeTxt_TextChanged(object sender, EventArgs e)
        {
            ErrorLbl.Visible = false;
        }
    }
}
