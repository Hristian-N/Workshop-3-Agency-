using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agency.Helpers
{
    public static class ValidationHelper
    {
        public static bool ValidateRange(string value, int minValue, int maxValue)
        {
            if (value.Length < minValue || value.Length > maxValue)
                return false;

            return true;
        }

        public static bool ValidateRange(int value, int minValue, int maxValue)
        {
            if (value < minValue || value > maxValue)
                return false;

            return true;
        }
        public static bool ValidateRange(double value, double minValue, double maxValue)
        {
            if (value < minValue || value > maxValue)
                return false;

            return true;
        }

    }
}
