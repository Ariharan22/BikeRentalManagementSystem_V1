using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentalManagementSystem
{
    public class ElectricBike : bike
    {
        public int BatteryCapacity { get; set; }
        public int MotorPower { get; set; }

        public ElectricBike(int bikeId, string brand, string model, decimal rentalPrice, int batteryCapacity, int motorPower)
            : base(bikeId, brand, model, rentalPrice)
        {
            BatteryCapacity = batteryCapacity;
            MotorPower = motorPower;
        }

        public override string DisplayBikeInfo()
        {
            return $"{base.DisplayBikeInfo()}, Battery Capacity: {BatteryCapacity} Ah, Motor Power: {MotorPower} W";
        }
    }

    public class PetrolBike : bike
    {
        public int FuelTankCapacity { get; set; }
        public int EngineCapacity { get; set; }

        public PetrolBike(int bikeId, string brand, string model, decimal rentalPrice, int fuelTankCapacity, int engineCapacity)
            : base(bikeId, brand, model, rentalPrice)
        {
            FuelTankCapacity = fuelTankCapacity;
            EngineCapacity = engineCapacity;
        }

        public override string DisplayBikeInfo()
        {
            return $"{base.DisplayBikeInfo()}, Fuel Tank Capacity: {FuelTankCapacity} L, Engine Capacity: {EngineCapacity} cc";
        }
    }

}