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
    public partial class RentNewCarForm : Form
    {
        List<Customer> customer = new List<Customer>();
        List<Places> placesList = new List<Places>();
        int price;
        int totaldays;
        public RentNewCarForm()
        {
            InitializeComponent();
        }

        private void RentNewCarForm_Load(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            placesList = da.GetPlacesList();
            customer = da.Customer(LoginForm.id);

            label2.Text = (customer[0].Firstname + " " + customer[0].Surrname + "\n" + customer[0].Adress + "\n" + customer[0].PhoneNumber + "\n" + customer[0].Email);
            label4.Text = (CustomerPanel.datagrid.Rows[CustomerPanel.idcar].Cells[1].Value.ToString() + " " + CustomerPanel.datagrid.Rows[CustomerPanel.idcar].Cells[2].Value.ToString()+"\n"+
                           CustomerPanel.datagrid.Rows[CustomerPanel.idcar].Cells[3].Value.ToString() + "\n" + CustomerPanel.datagrid.Rows[CustomerPanel.idcar].Cells[4].Value.ToString()+"\n"+
                           "doors: "+CustomerPanel.datagrid.Rows[CustomerPanel.idcar].Cells[5].Value.ToString()+"\n capacity: "+ CustomerPanel.datagrid.Rows[CustomerPanel.idcar].Cells[6].Value.ToString()+"\n"+
                           CustomerPanel.datagrid.Rows[CustomerPanel.idcar].Cells[7].Value.ToString()+"zł");

            foreach (Places places in placesList)
            {
                PlacescomboBox.Items.Add(places.address);
            }

            monthCalendar1.MinDate = DateTime.UtcNow;
            monthCalendar1.SelectionStart = DateTime.UtcNow;
            monthCalendar2.MinDate = DateTime.UtcNow;
            monthCalendar2.SelectionStart = DateTime.UtcNow;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            monthCalendar2.MinDate = monthCalendar1.SelectionRange.Start;
            if(monthCalendar1.SelectionRange.Start > monthCalendar2.SelectionRange.Start)
            {
                MessageBox.Show("You choose wrong date");
            }
            Price();
            label11.Text = Totaldays().ToString();
        }
        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            Price();
            label11.Text = Totaldays().ToString();
        }
        public void Price()
        {
            price = Convert.ToInt32(CustomerPanel.datagrid.Rows[CustomerPanel.idcar].Cells[7].Value) * Totaldays();
            label9.Text = (price.ToString() + "zł");
        }
        public int Totaldays()
        {
            totaldays = monthCalendar2.SelectionRange.Start.Subtract(monthCalendar1.SelectionRange.Start).Days + 1;
            return totaldays;
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Rentbutton_Click(object sender, EventArgs e)
        {
            if (PlacescomboBox.SelectedItem != null)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure?", "Make sure the data is correct",MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    DataAccess da = new DataAccess();
                    da.AddNewContract(Convert.ToInt32(CustomerPanel.datagrid.Rows[CustomerPanel.idcar].Cells[0].Value),customer[0].IdCustomer,PlacescomboBox.SelectedIndex+1,monthCalendar1.SelectionRange.Start, monthCalendar2.SelectionRange.Start,price);
                    MessageBox.Show("Contract successfully added");
                }
                else if (dialogResult == DialogResult.No)
                {
                    
                }
            }
            else 
            {
                MessageBox.Show("Choose pickup location");
            }
        }
    }
}
