using System;
using System.Text;
using Agency.Models.Contracts;

namespace Agency.Models
{
    public class Bus : Vehicle, IBus
    {
        private const int PassengerCapacityMinValue = 10;
        private const int PassengerCapacityMaxValue = 50;
        private const double PricePerKilometerMinValue = 0.10;
        private const double PricePerKilometerMaxValue = 2.50;

        private bool hasFreeTv;

        public Bus(int id, int passengerCapacity, double pricePerKilometer, bool hasFreeTv)
            : base(id, passengerCapacity, pricePerKilometer, PassengerCapacityMinValue, PassengerCapacityMaxValue, PricePerKilometerMinValue, PricePerKilometerMaxValue)
        {
            HasFreeTv = hasFreeTv;
        }

        public bool HasFreeTv
        {
            get
            {
                return hasFreeTv;
            }
            private set
            {
                hasFreeTv = value;
            }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Bus----");
            stringBuilder.Append(base.ToString());
            stringBuilder.Append($"Has free TV: {hasFreeTv}");

            return stringBuilder.ToString();
        }
    }
}
