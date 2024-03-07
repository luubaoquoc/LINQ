using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_LINQ
{
    class Truck : Vehicle
    {
        public string Company { get; set; }

        // Phương thức tạo danh sách các Truck
        public static List<Truck> CreateTruckList()
        {
            return new List<Truck>
        {
            new Truck("01","F-150", "Ford", 2018, 400000, "Ford Motors"),
            new Truck("02","Silverado", "Chevrolet", 2020, 450000, "General Motors"),
            new Truck("03","Ram 1500", "Dodge", 2019, 420000, "Stellantis"),
            new Truck("04","Tundra", "Toyota", 2017, 380000, "Toyota Motor Corporation")
        };
        }

        public Truck(string id, string name,string model, int year, decimal price, string company) : base(id, name, model, year, price)
        {
            Company = company;
        }
    }
}
