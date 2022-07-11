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
        List<Places> placesList = new List<Places>();
        public RentNewCarForm()
        {
            InitializeComponent();
        }

        private void RentNewCarForm_Load(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            placesList = da.GetPlacesList();
            
            foreach (Places places in placesList)
            {
                PlacescomboBox.Items.Add(places.address);
            }
        }
    }
}
