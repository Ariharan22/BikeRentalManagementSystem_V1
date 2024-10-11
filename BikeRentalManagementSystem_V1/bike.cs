using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentalManagementSystem
{
    public class bike
    {
        
        public int BikeId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal RentalPrice { get; set; }

        
        public static int TotalBikes { get; private set; }

        
        public bike(int bikeId, string brand, string model, decimal rentalPrice)
        {
            BikeId = bikeId;
            Brand = brand;
            Model = model;
            RentalPrice = rentalPrice;
            TotalBikes++;
        }

        
        public override string ToString()
        {
            return $"ID: {BikeId}, Brand: {Brand}, Model: {Model}, RentalPrice: {RentalPrice:C}";
        }

        
        public virtual string DisplayBikeInfo()
        {
            return $"ID: {BikeId}, Brand: {Brand}, Model: {Model}, RentalPrice: {RentalPrice:C}";
        }
    }
}