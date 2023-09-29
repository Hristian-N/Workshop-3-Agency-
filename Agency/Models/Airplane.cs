using System;
using System.Text;
using Agency.Helpers;
using Agency.Models.Contracts;

namespace Agency.Models
{
    public class Airplane : Vehicle, IAirplane
    {
        private const int PassengerCapacityMinValue = 1;
        private const int PassengerCapacityMaxValue = 800;
        //private const double PricePerKilometerMinValue = 0.10;
        //private const double PricePerKilometerMaxValue = 2.50;

        private bool isLowCost;

        public Airplane(int id, int passengerCapacity, double pricePerKilometer, bool isLowCost)
            : base(id, passengerCapacity, pricePerKilometer)
        {
            IsLowCost = isLowCost;
        }

        public bool IsLowCost
        {
            get
            {
                return isLowCost;
            }
            private set
            {
                isLowCost = value;
            }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Airplane----");
            stringBuilder.Append(base.ToString());
            stringBuilder.Append($"Is low-cost: {isLowCost}");

            return stringBuilder.ToString();
        }
    }
}
