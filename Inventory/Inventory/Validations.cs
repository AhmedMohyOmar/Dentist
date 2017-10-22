using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory;

namespace Inventory
{
    static public class Validations
    {
        static public bool ValidateLogin(string username, string password)
        {
            DentistToolsEntities context = new DentistToolsEntities();
            UserLogin User = new UserLogin();
            User = context.UserLogins.Where(u => u.UserName == username & u.Pass == password).FirstOrDefault();
            if (User == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        static public bool AddNewProduct(Product NewProduct)
        {
            DentistToolsEntities context = new DentistToolsEntities();
            if (SelectProduct(NewProduct.Code) == null)
            {
                context.Products.Add(NewProduct);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        static public Product SelectProduct(string code)
        {
            DentistToolsEntities context = new DentistToolsEntities();
            Product SelectedProduct = context.Products.Where(p => p.Code == code).FirstOrDefault();
            return SelectedProduct;
        }

        static public List<Product> SelectAllProducts()
        {
            DentistToolsEntities context = new DentistToolsEntities();
            return context.Products.ToList();
        }

        static public bool AddQuantity(int Quantity, String Code)
        {
            try
            {
                DentistToolsEntities context = new DentistToolsEntities();
                Product ModifiedProduct = new Product();
                ModifiedProduct = context.Products.Where(p => p.Code == Code).FirstOrDefault();
                ModifiedProduct.Qty += Quantity;
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
            
        }

        static public bool RevokeQuantity(int Quantity, String Code)
        {
            try
            {
                DentistToolsEntities context = new DentistToolsEntities();
                Product ModifiedProduct = new Product();
                ModifiedProduct = context.Products.Where(p => p.Code == Code).FirstOrDefault();
                ModifiedProduct.Qty -= Quantity;
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}
