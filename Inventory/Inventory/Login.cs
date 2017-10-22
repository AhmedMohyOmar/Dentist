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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (Validations.ValidateLogin(UserNameTxt.Text, PasswordTxt.Text))
            {
                Functions FunctionForm = new Functions();
                FunctionForm.ShowDialog();
            }
            else
            {
                ErrorLbl.Visible = true;
            }
            
        }

        private void UserNameTxt_TextChanged(object sender, EventArgs e)
        {
            ErrorLbl.Visible = false;
        }

        private void PasswordTxt_TextChanged(object sender, EventArgs e)
        {
            ErrorLbl.Visible = false;
        }
    }
}
