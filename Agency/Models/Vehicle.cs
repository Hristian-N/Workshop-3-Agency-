using System;
using System.Runtime.ConstrainedExecution;
using Agency.Models.Contracts;

namespace Agency.Models
{
    public abstract class Vehicle : IVehicle
    {

        private static int id;
        private int passengerCapacity;
        private double pricePerKilometer;

        public Vehicle(int id, int passengerCapacity, double pricePerKilometer,
            int PassengerCapacityMinValue, int PassengerCapacityMaxValue,
            double PricePerKilometerMinValue, double PricePerKilometerMaxValue)
        {
            Id = id;
            PassengerCapacity = passengerCapacity;
            PricePerKilometer = pricePerKilometer;
        }

        public int Id
        {
            get
            {
                return id;
            }
            private set
            {
                id++;
            }
        }

        public virtual int PassengerCapacity
        {
            get
            {
                return passengerCapacity;
            }
            protected set
            {

                if (value < 1 || value > 800)
                    throw new Exception("A vehicle with less than 1 passengers or more than 800 passengers cannot exist!");

                passengerCapacity = value;
            }
        }

        public double PricePerKilometer
        {
            get
            {
                return pricePerKilometer;
            }
            private set
            {

                if (value < 0.10 || value > 2.50)
                    throw new Exception("A vehicle with a price per kilometer lower than $0.10 or higher than $2.50 cannot exist!");

                pricePerKilometer = value;
            }
        }


        public override string ToString()
        {
            return $"Passenger capacity: {passengerCapacity} \nPrice per kilometer: {pricePerKilometer}";
        }
    }

}
