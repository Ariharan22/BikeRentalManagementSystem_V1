using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentalManagementSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            BikeManager bikeManager = new BikeManager();
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("Bike Rental Management System:");
                Console.WriteLine("1. Add a Bike");
                Console.WriteLine("2. View All Bikes");
                Console.WriteLine("3. Update a Bike");
                Console.WriteLine("4. Delete a Bike");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        
                        Console.Write("Enter Bike ID: ");
                        int bikeId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Bike Brand: ");
                        string brand = Console.ReadLine();
                        Console.Write("Enter Bike Model: ");
                        string model = Console.ReadLine();
                        Console.Write("Enter Bike Rental Price: ");
                        decimal rentalPrice = Convert.ToDecimal(Console.ReadLine());

                        bikeManager.CreateBike(bikeId, brand, model, rentalPrice);
                        break;

                    case 2:
                        
                        bikeManager.ReadBikes();
                        break;

                    case 3:
                        
                        Console.Write("Enter Bike ID to Update: ");
                        int updateId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter New Brand: ");
                        string newBrand = Console.ReadLine();
                        Console.Write("Enter New Model: ");
                        string newModel = Console.ReadLine();
                        Console.Write("Enter New Rental Price: ");
                        decimal newRentalPrice = Convert.ToDecimal(Console.ReadLine());

                        bikeManager.UpdateBike(updateId, newBrand, newModel, newRentalPrice);
                        break;

                    case 4:
                        
                        Console.Write("Enter Bike ID to Delete: ");
                        int deleteId = Convert.ToInt32(Console.ReadLine());
                        bikeManager.DeleteBike(deleteId);
                        break;

                    case 5:
                        
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }

                if (option != 5)
                {
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                }
            }
        }
    }
}
