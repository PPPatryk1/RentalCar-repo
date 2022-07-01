using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using System.Data;

namespace RentalCar
{
    public partial class Main : Form
    {
        List<Car> CarList = new List<Car>();
        string WhatYouDo;
        public Main()
        {
            InitializeComponent();
            Update();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            comboBox2.Text = "All";
            Refresh();
            DeleteButton.Enabled = true;
            UpdateButton.Enabled = true;
            EditingPanel.Visible = false;

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

        private void AddNewCar_Click(object sender, EventArgs e)
        {
            EditingPanel.Visible = true;
            WhatYouDo = "Add";
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void CarDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DeleteButton.Enabled = true;
            UpdateButton.Enabled = true;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?","Are you sure?", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                DataAccess da = new DataAccess();
                da.DeleteCar(CarDataGrid.CurrentRow.Index,CarList);
                Refresh();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            EditingPanel.Visible = true;
            WhatYouDo = "Update";
            int i = CarDataGrid.CurrentRow.Index;
            BrandTextBox.Text = CarList[i].brand;
            ModelTextBox.Text = CarList[i].model;
            EngineCombo1.Text = CarList[i].engineType;
            TransmissionCombo1.Text = CarList[i].transmission;
            DoorCombo1.Text = CarList[i].doorNumber.ToString();
            BootyCapacityUpDown.Value = CarList[i].bootCapacity;
            PriceNumericUpDown.Value = CarList[i].price;
            AvailablecheckBox.Checked = CarList[i].status;
            
        }

        private void Confrim_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            if (Limitations() == true)
            {
                if (WhatYouDo == "Add")
                {
                    da.AddNewCar(BrandTextBox.Text, ModelTextBox.Text, EngineCombo1.Text, TransmissionCombo1.Text, int.Parse(DoorCombo1.Text), Convert.ToInt32(BootyCapacityUpDown.Value), Convert.ToInt32(PriceNumericUpDown.Value), Convert.ToBoolean(1));
                }
                else if (WhatYouDo == "Update")
                {
                    int i = CarDataGrid.CurrentRow.Index;
                    CarList[i].brand = BrandTextBox.Text;
                    CarList[i].model = ModelTextBox.Text;
                    CarList[i].engineType = EngineCombo1.Text;
                    CarList[i].transmission = TransmissionCombo1.Text;
                    CarList[i].doorNumber = Convert.ToInt32(DoorCombo1.Text);
                    CarList[i].bootCapacity = Convert.ToInt32(BootyCapacityUpDown.Value);
                    CarList[i].price = Convert.ToInt32(PriceNumericUpDown.Value);
                    CarList[i].status = AvailablecheckBox.Checked;
                    da.UpdateCar(CarDataGrid.CurrentRow.Index, CarList);
                }
                EditingPanel.Visible = false;
                Refresh();
                ClearForm();
            }
        }

        private void AvailablecheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(AvailablecheckBox.Checked == true)
            {
                AvailablecheckBox.Text = "Yes";
            }
            else if (AvailablecheckBox.Checked == false)
            {
                AvailablecheckBox.Text = "No";
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            EditingPanel.Visible = false;
            ClearForm();
        }
        public void ClearForm()
        {
            BrandTextBox.Text = "";
            ModelTextBox.Text = "";
            EngineCombo1.Text = null;
            TransmissionCombo1.Text = null;
            DoorCombo1.Text = null;
            BootyCapacityUpDown.Value = 0;
            PriceNumericUpDown.Value = 0;
            AvailablecheckBox.Checked = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Refresh();
            Sorting sort = new Sorting();
            if (comboBox1.Text == "default")    {sort.Default(CarList);}
            else if(comboBox1.Text== "Price lowest")    {sort.PriceLow(CarList);}
            else if (comboBox1.Text == "Price highest")     {sort.PriceHigh(CarList);}
            else if (comboBox1.Text == "Brand A-Z")     {sort.BrandAZ(CarList);}
            else if (comboBox1.Text == "Brand Z-A")     { sort.BrandZA(CarList);}
            else if (comboBox1.Text == "Capacity lowest")   {sort.CapacityLow(CarList);}
            else if (comboBox1.Text == "Capacity highest")  {sort.CapacityHigh(CarList);}
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Refresh();
        }
        public bool Limitations()
        {
            if(BrandTextBox.Text.Length>0 && BrandTextBox.Text.Length <= 30)
            {
                if(ModelTextBox.Text.Length > 0 && ModelTextBox.Text.Length <= 50)
                {
                    if (EngineCombo1.SelectedItem != null)
                    {
                        if (TransmissionCombo1.SelectedItem != null)
                        {
                            if (DoorCombo1.SelectedItem != null)
                            {
                                if (BootyCapacityUpDown.Value > 0)
                                {
                                    if (PriceNumericUpDown.Value > 0)
                                    {
                                        return true;
                                    }
                                    else { MessageBox.Show("The price cannot be lower than 0"); return false; }
                                }
                                else { MessageBox.Show("The capacity cannot be lower than 0"); return false; }
                            }
                            else { MessageBox.Show("The door number cannot be empty"); return false; }
                        }
                        else { MessageBox.Show("The transmission cannot be empty"); return false; }
                    }
                    else { MessageBox.Show("The Engine type cannot be empty"); return false; }
                }
                else { MessageBox.Show("The model name cannot be empty and longer than 50 signs"); return false; }
            }
            else { MessageBox.Show("The brand name cannot be empty and longer than 30 signs"); return false; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            log.Show();
        }
    }
}