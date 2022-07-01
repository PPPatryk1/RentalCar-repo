using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalCar
{
    public partial class LoginForm : Form
    {
        List<Customer> customer = new List<Customer>();
        public LoginForm()
        {
            InitializeComponent();
            PasswordtextBox.PasswordChar = Convert.ToChar("*");
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();

            customer = da.Login(LoginTextBox.Text,PasswordtextBox.Text);
            
            if(customer.Count == 1)
            {
                MessageBox.Show("You are logged");
            }
            else
            {
                MessageBox.Show("Wrong email or password");
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
