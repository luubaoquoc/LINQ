using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Hiển thị các xe có giá trong khoảng 100.000 - 250.000 ");
                Console.WriteLine("2. Các xe có năm sản xuất > 1990");
                Console.WriteLine("3. Gom các xe theo hãng sản xuất, tính tổng giá trị theo nhóm");
                Console.WriteLine("4. Hiển thị danh sách Truck theo thứ tự năm sản xuất mới nhất");
                Console.WriteLine("5. Hiển thị tên cty chủ quản của Truck");

                Console.WriteLine("Nhập Lựa chọn");
                int choice = int.Parse(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        DisplayFilteredCars();
                        break;
                    case 2:
                        DisplayCarsManufacturedAfter1990();
                        break;
                    case 3:
                        DisplayGroupedCars();
                        break;
                    case 4:
                        DisplaySortedTrucks();
                        break;
                    case 5:
                        DisplayTruckCompanies();
                        break;
                    default:
                        Console.WriteLine("Chọn sai! mời chọn lại");
                        break;
                }

            }
        }


        static void DisplayFilteredCars()
        {

            List<Car> cars = Car.CreateCarList();

            // Hiển thị các xe có giá trong khoảng 100.000 đến 250.000 
            var filteredCars = cars.Where(car => car.Price >= 100000 && car.Price <= 250000);
            Console.WriteLine("\nFiltered Cars:");
            foreach (var car in filteredCars)
            {
                Console.WriteLine($"{car.ID} - {car.Name} - {car.Model} - Price: {car.Price} -  {car.Year} - {car.SeatingCapacity}");
            }
        }
        static void DisplayCarsManufacturedAfter1990()
        {
            List<Car> cars = Car.CreateCarList();

            //Các xe có năm sản xuất > 1990
            Console.WriteLine("\nDisplayCarsManufacturedAfter1990:");
            var filteredCarsByYear = cars.Where(car => car.Year > 1990);
            foreach (var car in filteredCarsByYear)
            {
                Console.WriteLine($"{car.ID} - {car.Name} - {car.Model} - {car.Price} - Year: {car.Year} - {car.SeatingCapacity}");
            }
        }

        static void DisplayGroupedCars()
        {
            List<Car> cars = Car.CreateCarList();

            // Gom các xe theo hãng sản xuất và tính tổng giá trị theo nhóm
            var groupedCars = cars.GroupBy(car => car.Model)
                                  .Select(group => new { Model = group.Key, TotalPrice = group.Sum(car => car.Price) });
            Console.WriteLine("\nGrouped Cars:");
            foreach (var group in groupedCars)
            {
                Console.WriteLine($"{group.Model}: Total Price = {group.TotalPrice}");
            }
        }

        static void DisplaySortedTrucks()
        {
            // Tạo danh sách các Truck
            List<Truck> trucks = Truck.CreateTruckList();
            

            // Hiển thị danh sách Truck theo thứ tự năm sản xuất mới nhất
            Console.WriteLine("\nTrucks Sorted by Year:");
            var sortedTrucks = trucks.OrderByDescending(truck => truck.Year);
            foreach (var truck in sortedTrucks)
            {
                Console.WriteLine($"{truck.ID} - {truck.Name} - {truck.Model} - Year: {truck.Year} - {truck.Price} - {truck.Company}");
            }
        }

        static void DisplayTruckCompanies()
        {
            // Tạo danh sách các Truck
            List<Truck> trucks = Truck.CreateTruckList();


            // Hiển thị tên công ty chủ quản của Truck
            Console.WriteLine("\nTruck Companies:");
            foreach (var truck in trucks)
            {
                Console.WriteLine($"{truck.ID} - {truck.Name} - {truck.Model} - {truck.Year} - {truck.Price} - Company: {truck.Company}");
            }
        }
    }
}
