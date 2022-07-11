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
        List<Administrator> admins = new List<Administrator>();
        public LoginForm()
        {
            InitializeComponent();
            PasswordtextBox.PasswordChar = Convert.ToChar("*");
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (CustomerradioButton.Checked == true)
            {
                DataAccess da = new DataAccess();

                customer = da.Login(LoginTextBox.Text, PasswordtextBox.Text);

                if (customer.Count == 1)
                {
                    CustomerPanel cp = new CustomerPanel();
                    cp.Show();
                }
                else
                {
                    MessageBox.Show("Wrong email or password");
                }
            }
            else if (CustomerradioButton.Checked == false)
            {
                DataAccess da = new DataAccess();
                admins = da.LoginAdmin(LoginTextBox.Text, PasswordtextBox.Text);

                if(admins.Count == 1)
                {
                    AdminPanel ap = new AdminPanel();
                    ap.Show();
                }
                else
                {
                    MessageBox.Show("Wrong Admin code or password");
                }
                
            }
            else { MessageBox.Show("Choose who you are"); }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (CustomerradioButton.Checked == true)
            {
                RegisterForm rf = new RegisterForm();
                rf.Show();
            }
            else if (CustomerradioButton.Checked == false)
            {
                MessageBox.Show("If you want create admin account you should contact with your supervisor");
            }
            else { MessageBox.Show("Choose who you are"); }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminPanel admin = new AdminPanel();
            admin.Show();
        }

        private void AdminradioButton_CheckedChanged(object sender, EventArgs e)
        {
            AdminradioButton.ForeColor = Color.White;
            CustomerradioButton.ForeColor = Color.Black;
            label1.Text = "Admin ID";
        }

        private void CustomerradioButton_CheckedChanged(object sender, EventArgs e)
        {
            AdminradioButton.ForeColor = Color.Black;
            CustomerradioButton.ForeColor = Color.White;
            label1.Text = "Email";
        }
    }
}
