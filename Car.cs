using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_LINQ
{
    class Car : Vehicle
    {
        public int SeatingCapacity { get; set; }
        // Phương thức tạo danh sách các Car
        public static List<Car> CreateCarList()
        {
            return new List<Car> 
        {
            new Car("01","Corolla", "Toyota", 2022, 200000,4),
            new Car("02","Accord", "Honda", 1989, 150000,4),
            new Car("03","Fusion", "Ford", 2005, 180000,4),
            new Car("04","Camry", "Toyota", 2000, 220000,4),
            new Car("05","Chevrolet", "Malibu", 1998, 130000,4),
            new Car("06","Civic", "Honda", 2008, 240000,4),
            new Car("07","Focus", "Ford", 2010, 260000,4),
            new Car("08","Rav4", "Toyota", 2015, 300000,4),
            new Car("09","Altima", "Nissan", 2019, 280000,4)
        };
        }

        public Car(string id, string name,string model, int year, decimal price, int seatingCapacity) : base(id, name, model, year, price)
        {
            SeatingCapacity = seatingCapacity;
        }
    }
}
