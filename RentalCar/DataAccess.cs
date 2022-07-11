using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace RentalCar
{
    class DataAccess
    {
        public List<Car> GetCarList()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CarDB")))
            {
                var output = connection.Query<Car>("[dbo].[AllCars]").ToList();
                return output;
            }
        }
        public void AddNewCar(string Brand, string Model, string EngineType, string Transmission, int DoorNumber, int BootCapacity, int Price, bool Status)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CarDB")))
            {
                List<Car> car = new List<Car>();
                car.Add(new Car{brand = Brand, model = Model, engineType = EngineType, transmission = Transmission, doorNumber = DoorNumber, bootCapacity = BootCapacity, price = Price, status = Status});
                connection.Execute("[dbo].[AddNewCar] @Brand, @Model, @EngineType, @Transmission, @DoorNumber, @BootCapacity, @Price", car);
            }
        }
        public void DeleteCar(int IDCar, List<Car> list)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CarDB")))
            {
                connection.Execute("[dbo].[DeleteCar] @IDCar", list[IDCar]);
            }
        }
        public void UpdateCar(int IDCar, List<Car> list)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CarDB")))
            {
                connection.Execute("[dbo].[UpdateCar] @IDCar, @Brand, @Model, @EngineType, @Transmission, @DoorNumber, @BootCapacity, @Price, @Status",list[IDCar]);
            }
        }
        public List<Car> GetCarListAvailable()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CarDB")))
            {
                var output = connection.Query<Car>("[dbo].[OnlyAvailable]").ToList();
                return output;
            }
        }
        public List<Car> GetCarListUnavailable()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CarDB")))
            {
                var output = connection.Query<Car>("[dbo].[OnlyUnavailable]").ToList();
                return output;
            }
        }

        //--------------------------------------------------------------------------------------------------

        public List<Customer> Login(string login, string password)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CarDB")))
            {
                var output = connection.Query <Customer>($"[dbo].[CorrectUser] @Email='{login}', @Password='{password}'").ToList();
                return output;        
            }
        }
        public int EmailCheck(string email) //Chwilowo nie działa
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CarDB")))
            {
                int output = Convert.ToInt32(connection.ExecuteScalar($"[dbo].[EmailCheck] @Email",new { @Email = email }));
                return output;
                
            }
        }
        public void AddNewCustomer(string Firstname, string Surrname, string Address, int Phone, string Email, string Password)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CarDB")))
            {
                List<Customer> customers = new List<Customer>();
                customers.Add(new Customer { Firstname = Firstname, Surrname = Surrname, Adress = Address, PhoneNumber = Phone, Email = Email, Password = Password });
                connection.Execute("[dbo].[AddNewCustomer] @Firstname, @Surrname, @Adress, @PhoneNumber, @Email, @Password", customers);
            }
        }
        public List<Administrator> LoginAdmin(string admincode, string password)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CarDB")))
            {
                var output = connection.Query<Administrator>($"[dbo].[CorrectAdmin] @AdminCode='{admincode}', @Password='{password}'").ToList();
                return output;
            }
        }

        //---------------------------------------------------------------------------------------------------------
        public List<Places> GetPlacesList()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("CarDB")))
            {
                var output = connection.Query<Places>("[dbo].[AllPlaces]").ToList();
                return output;
            }
        }
    }
}
