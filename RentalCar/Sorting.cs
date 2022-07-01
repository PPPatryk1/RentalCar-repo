using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalCar
{
    class Sorting
    {
        public void PriceLow(List<Car> list)
        {
            list.Sort(delegate (Car x, Car y)
            {
                return x.price.CompareTo(y.price);
            });
        }
        public void PriceHigh(List<Car> list)
        {
            list.Sort(delegate (Car x, Car y)
            {
                return y.price.CompareTo(x.price);
            });
        }
        public void BrandAZ(List<Car> list)
        {
            list.Sort(delegate (Car x, Car y)
            {
                return x.brand.CompareTo(y.brand);
            });
        }
        public void BrandZA(List<Car> list)
        {
            list.Sort(delegate (Car x, Car y)
            {
                return y.brand.CompareTo(x.brand);
            });
        }
        public void CapacityLow(List<Car> list)
        {
            list.Sort(delegate (Car x, Car y)
            {
                return x.bootCapacity.CompareTo(y.bootCapacity);
            });
        }
        public void CapacityHigh(List<Car> list)
        {
            list.Sort(delegate (Car x, Car y)
            {
                return y.bootCapacity.CompareTo(x.bootCapacity);
            });
        }
        public void Default(List<Car> list)
        {
            list.Sort(delegate (Car x, Car y)
            {
                return x.idCar.CompareTo(y.idCar);
            });
        }
    }
}
