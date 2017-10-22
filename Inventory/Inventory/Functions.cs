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
    public partial class Functions : Form
    {
        public Functions()
        {
            InitializeComponent();
        }

        private void NewProductTab_Click(object sender, EventArgs e)
        {
            NewProduct NewProductForm = new NewProduct();
            NewProductForm.ShowDialog();
        }

        private void AddProductTab_Click(object sender, EventArgs e)
        {
            AddProduct AddProductForm = new AddProduct();
            AddProductForm.ShowDialog();
        }

        private void RevokeProductTab_Click(object sender, EventArgs e)
        {
            RevokeProduct RevokeProductForm = new RevokeProduct();
            RevokeProductForm.ShowDialog();
        }

        private void ViewProductsTab_Click(object sender, EventArgs e)
        {
            ViewProducts ViewProductsForm = new ViewProducts();
            ViewProductsForm.ShowDialog();
        }

        private void ViewCashTab_Click(object sender, EventArgs e)
        {
            ViewCash ViewCashForm = new ViewCash();
            ViewCashForm.ShowDialog();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
