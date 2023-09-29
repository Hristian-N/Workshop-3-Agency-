using System;
using System.Text;
using Agency.Helpers;
using Agency.Models.Contracts;

namespace Agency.Models
{
    public class Journey : IJourney
    {
        private const int StartLocationMinLength = 5;
        private const int StartLocationMaxLength = 25;
        private const int DestinationMinLength = 5;
        private const int DestinationMaxLength = 25;
        private const int DistanceMinValue = 5;
        private const int DistanceMaxValue = 5000;
        private const string StartingLocationException = "The StartingLocation's length cannot be less than 5 or more than 25 symbols long.";
        private const string DestinationException = "The Destination's length cannot be less than 5 or more than 25 symbols long..";

        private string startLocation;
        private string destination;
        private int distance;
        private IVehicle vehicle;

        public Journey(int id, string from, string to, int distance, IVehicle vehicle)
        {
            startLocation = from;
        }

        public string StartLocation
        {
            get
            {
                return startLocation;
            }
            private set
            {
                if (ValidationHelper.ValidateRange(value, StartLocationMinLength, StartLocationMaxLength))
                    throw new ArgumentException(StartingLocationException);

                startLocation = value;
            }
        }

        public string Destination
        {
            get
            {
                return destination;
            }
            private set
            {
                if (ValidationHelper.ValidateRange(value, DestinationMinLength, DestinationMaxLength))
                    throw new ArgumentException(DestinationException);

                destination = value;
            }
        }

        public int Distance
        {
            get
            {
                return distance;
            }
            private set
            {
                if (ValidationHelper.ValidateRange(value, DistanceMinValue, DistanceMaxValue))
                    throw new ArgumentException(DestinationException);

                distance = value;
            }
        }

        public IVehicle Vehicle
        {
            get
            {
                return vehicle;
            }
            set
            {
                vehicle = value;
            }
        }

        public int Id => throw new NotImplementedException();

        public double CalculatePrice()
        {
            return Distance * Vehicle.PricePerKilometer;
        }

        public override string ToString()
        {

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Journey----");
            stringBuilder.Append($"Start location: {StartLocation}");
            stringBuilder.Append($"Destination: {Destination}");
            stringBuilder.Append($"Distance: {Distance}");
            stringBuilder.Append($"Travel costs: {CalculatePrice()}");

            return stringBuilder.ToString();
        }
    }
}
