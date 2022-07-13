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
    public partial class CustomerPanel : Form
    {
        List<Car> CarList = new List<Car>();
        List<Customer> customer = new List<Customer>();
        public static DataGridView datagrid;
        public static int idcar;
        public CustomerPanel()
        {
            InitializeComponent();
        }
        private void Update()
        {
            CarDataGrid.DataSource = CarList;

            CarDataGrid.EnableHeadersVisualStyles = false;
            CarDataGrid.BackgroundColor = Color.White;
            CarDataGrid.GridColor = Color.Black;
            CarDataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            CarDataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            CarDataGrid.DefaultCellStyle.SelectionBackColor = Color.DimGray;

            CarDataGrid.Columns[0].HeaderCell.Value = "ID";
            CarDataGrid.Columns[0].Width = 30;

            CarDataGrid.Columns[1].HeaderCell.Value = "Brand";

            CarDataGrid.Columns[2].HeaderCell.Value = "Model";

            CarDataGrid.Columns[3].HeaderCell.Value = "Engine type";

            CarDataGrid.Columns[4].HeaderCell.Value = "Transmission";

            CarDataGrid.Columns[5].HeaderCell.Value = "Door number";
            CarDataGrid.Columns[5].Width = 70;

            CarDataGrid.Columns[6].HeaderCell.Value = "Boot Capacity (liters)";
            CarDataGrid.Columns[6].Width = 70;

            CarDataGrid.Columns[7].HeaderCell.Value = "Price (zł/day)";
            CarDataGrid.Columns[7].Width = 70;

            CarDataGrid.Columns[8].HeaderCell.Value = "Available";
            CarDataGrid.Columns[8].Width = 70;
        }
        public void Refresh()
        {
            DataAccess da = new DataAccess();

            if (comboBox2.Text == "All") { CarList = da.GetCarList(); }
            else if (comboBox2.Text == "Only available") { CarList = da.GetCarListAvailable(); }
            else if (comboBox2.Text == "Only unavailable") { CarList = da.GetCarListUnavailable(); }

            Update();

        }

        private void Logoutbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Rentbutton_Click(object sender, EventArgs e)
        {
            datagrid = CarDataGrid;
            idcar = CarDataGrid.CurrentRow.Index;
            if (CarList[idcar].status == true)
            {
                RentNewCarForm rncf = new RentNewCarForm();
                rncf.Show();
            }
            else { MessageBox.Show("This car is temporarily unavailable"); }
        }

        private void CarDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CustomerPanel_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "Default";
            comboBox2.Text = "All";
            Refresh();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Refresh();
            Sorting sort = new Sorting();
            if (comboBox1.Text == "default") { sort.Default(CarList); }
            else if (comboBox1.Text == "Price lowest") { sort.PriceLow(CarList); }
            else if (comboBox1.Text == "Price highest") { sort.PriceHigh(CarList); }
            else if (comboBox1.Text == "Brand A-Z") { sort.BrandAZ(CarList); }
            else if (comboBox1.Text == "Brand Z-A") { sort.BrandZA(CarList); }
            else if (comboBox1.Text == "Capacity lowest") { sort.CapacityLow(CarList); }
            else if (comboBox1.Text == "Capacity highest") { sort.CapacityHigh(CarList); }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
