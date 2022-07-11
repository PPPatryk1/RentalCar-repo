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
    public partial class RegisterForm : Form
    {
        List<Customer> customer = new List<Customer>();
        int code;
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Createbutton_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();

            customer = da.Login(EmailtextBox.Text, PasstextBox.Text);

            if (customer.Count == 1)
            {
                MessageBox.Show("An account with this e-mail address already exists");
            }
            else
            {
                MessageBox.Show("an e-mail with an activation code was sent to your e-mail");

                Random codeGenerator = new Random();
                code = codeGenerator.Next(100000,1000000);
                //EmailSender emailSender = new EmailSender();
                //emailSender.Sender(EmailtextBox.Text,FnametextBox.Text,code); --Wysyłanie maila
                label7.Visible = true;
                label9.Visible = true; //Label stworzony dla wersji roboczej
                label9.Text = code.ToString();
                ConfrimtextBox.Visible = true;
                Confrimbutton.Visible = true;

                FnametextBox.Enabled = false;
                SnametextBox.Enabled = false;
                AddresstextBox.Enabled = false;
                PhonetextBox.Enabled = false;
                EmailtextBox.Enabled = false;
                PasstextBox.Enabled = false;
                Pass2textBox.Enabled = false;
            }

            //Chwilowo nie działa
            /*DataAccess da = new DataAccess();
            int i = da.EmailCheck(EmailtextBox.Text);
            if (Limitations() == true)
            {
                if (i == 0)
                {
                    MessageBox.Show("an e-mail with an activation code was sent to your e-mail");
                   
                }
                else if(i == 1)
                {
                    MessageBox.Show("An account with this e-mail address already exists");
                }
            }*/
        }
        public bool Limitations()
        {
            if (FnametextBox.Text.Length > 0 && FnametextBox.Text.Length <= 30)
            {
                if (SnametextBox.Text.Length > 0 && SnametextBox.Text.Length <= 30)
                {
                    if (AddresstextBox.Text.Length > 0 && AddresstextBox.Text.Length <= 200)
                    {
                        if (PhonetextBox.Text.Length == 9)
                        {
                            if (EmailtextBox.Text.Length > 0 && EmailtextBox.Text.Length <= 50)
                            {
                                if (PasstextBox.Text.Length > 0 && PasstextBox.Text.Length <= 20)
                                {
                                    if (Pass2textBox.Text == PasstextBox.Text)
                                    {
                                        return true;
                                    }
                                    else { MessageBox.Show("Passwords must be identical"); return false; }
                                }
                                else { MessageBox.Show("The password cannot be empty and longer than 20 signs"); return false; }
                            }
                            else { MessageBox.Show("The email address cannot be empty and longer than 50 signs"); return false; }
                        }
                        else { MessageBox.Show("The phone number must consist 9 numbers "); return false; }
                    }
                    else { MessageBox.Show("The address cannot be empty and longer than 200 signs"); return false; }
                }
                else { MessageBox.Show("The surrname name cannot be empty and longer than 30 signs"); return false; }
            }
            else { MessageBox.Show("The first name cannot be empty and longer than 30 signs"); return false; }
        }

        private void PhonetextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void FnametextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar);
        }

        private void SnametextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar);
        }

        private void Confrimbutton_Click(object sender, EventArgs e)
        {
            if (ConfrimtextBox.Text == code.ToString())
            {
                try
                {
                    DataAccess da = new DataAccess();
                    da.AddNewCustomer(FnametextBox.Text, SnametextBox.Text, AddresstextBox.Text, Convert.ToInt32(PhonetextBox.Text), EmailtextBox.Text, PasstextBox.Text);
                    MessageBox.Show("Account create successfully");
                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Unknown error, try create account again");
                    this.Close();
                }
            }
            else { MessageBox.Show("Wrong code"); }
        }
    }
}
