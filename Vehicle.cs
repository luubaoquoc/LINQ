using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_LINQ
{
    class Vehicle
    {
        public string ID { get; set; }
        public string Name { get; set; }

        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        public Vehicle(string id, string name,string model, int year, decimal price)
        {
            ID = id;
            Name = name;
            Model = model;
            Year = year;
            Price = price;
        }
    }
}
