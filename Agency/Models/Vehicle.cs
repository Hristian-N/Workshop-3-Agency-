using System;
using System.Runtime.ConstrainedExecution;
using Agency.Exceptions;
using Agency.Helpers;
using Agency.Models.Contracts;

namespace Agency.Models
{
    public abstract class Vehicle : IVehicle
    {

        private static int id;
        protected int passengerCapacity;
        private double pricePerKilometer;

        private const string PassangerException = "A vehicle with less than 1 passengers or more than 800 passengers cannot exist!";
        private const string PriceException = "A vehicle with a price per kilometer lower than $0.10 or higher than $2.50 cannot exist!";
        protected const string InvalidValueException = "Invalid value for passengerCapacity. Should be an integer number.";

        public Vehicle(int id, int passengerCapacity, double pricePerKilometer)
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
                if (ValidationHelper.ValidateRange(value, 1, 800))
                    throw new InvalidUserInputException(PassangerException);

                passengerCapacity = value;
            }
        }

        public virtual double PricePerKilometer
        {
            get
            {
                return pricePerKilometer;
            }
            protected set
            {
                
                if (ValidationHelper.ValidateRange(value, 0.10, 2.50))
                    throw new InvalidUserInputException(PriceException);

                pricePerKilometer = value;
            }
        }

        public override string ToString()
        {
            return $"Passenger capacity: {passengerCapacity} \nPrice per kilometer: {pricePerKilometer}";
        }
    }

}
