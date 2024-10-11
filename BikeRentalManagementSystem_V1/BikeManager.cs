using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentalManagementSystem
{
    public class BikeManager
    {
        
        private List<bike> bikes = new List<bike>();

       
        public void CreateBike(int bikeId, string brand, string model, decimal rentalPrice)
        {
            if (ValidateBikeRentalPrice(rentalPrice))
            {
                bike newBike = new bike(bikeId, brand, model, rentalPrice);
                bikes.Add(newBike);
                Console.WriteLine("Bike added successfully!");
            }
        }

        
        public void ReadBikes()
        {
            if (bikes.Count == 0)
            {
                Console.WriteLine("No bikes available.");
            }
            else
            {
                foreach (var bike in bikes)
                {
                    Console.WriteLine(bike.ToString());
                }
            }
        }

        
        public void UpdateBike(int bikeId, string newBrand, string newModel, decimal newRentalPrice)
        {
            bike bikeToUpdate = bikes.FirstOrDefault(b => b.BikeId == bikeId);
            if (bikeToUpdate != null)
            {
                if (ValidateBikeRentalPrice(newRentalPrice))
                {
                    bikeToUpdate.Brand = newBrand;
                    bikeToUpdate.Model = newModel;
                    bikeToUpdate.RentalPrice = newRentalPrice;
                    Console.WriteLine("Bike updated successfully!");
                }
            }
            else
            {
                Console.WriteLine("Bike with the given ID does not exist.");
            }
        }

        
        public void DeleteBike(int bikeId)
        {
            bike bikeToDelete = bikes.FirstOrDefault(b => b.BikeId == bikeId);
            if (bikeToDelete != null)
            {
                bikes.Remove(bikeToDelete);
                Console.WriteLine("Bike deleted successfully!");
            }
            else
            {
                Console.WriteLine("Bike with the given ID does not exist.");
            }
        }

        
        public bool ValidateBikeRentalPrice(decimal rentalPrice)
        {
            if (rentalPrice <= 0)
            {
                Console.WriteLine("Rental price must be a positive value. Please enter a valid price.");
                return false;
            }
            return true;
        }
    }
}