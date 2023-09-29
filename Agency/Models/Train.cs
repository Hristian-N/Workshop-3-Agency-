using System;
using System.Runtime.ConstrainedExecution;
using System.Text;
using Agency.Exceptions;
using Agency.Helpers;
using Agency.Models.Contracts;

namespace Agency.Models
{
    public class Train : Vehicle, ITrain
    {
        private const int PassengerCapacityMinValue = 30;
        private const int PassengerCapacityMaxValue = 150;
        //private const double PricePerKilometerMinValue = 0.10;
        //private const double PricePerKilometerMaxValue = 2.50;
        private const int CartsMinValue = 1;
        private const int CartsMaxValue = 15;
        private const string PassangerCapacityException = "A train cannot have less than 30 passengers or more than 150 passengers.";
        private const string CartsException = "A train cannot have less than 1 cart or more than 15 carts.";

        private int carts;

        public Train(int id, int passengerCapacity, double pricePerKilometer, int carts)
            : base(id, passengerCapacity, pricePerKilometer)
        {
            Carts = carts;
        }

        public override int PassengerCapacity
        {
            get
            {
                return base.passengerCapacity;
            }
            protected set
            {

                if (ValidationHelper.ValidateRange(value, PassengerCapacityMinValue, PassengerCapacityMaxValue))
                    throw new InvalidUserInputException(PassangerCapacityException);

                base.passengerCapacity = value;
            }
        }

        public int Carts
        {
            get
            {
                return carts;
            }
            private set
            {
                if (ValidationHelper.ValidateRange(value, CartsMinValue, CartsMaxValue))
                    throw new Exception(CartsException);

                carts = value;
            }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Train----");
            stringBuilder.Append(base.ToString());
            stringBuilder.Append($"Carts amount: {carts}");

            return stringBuilder.ToString();
        }
    }
}
