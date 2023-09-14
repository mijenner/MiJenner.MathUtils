using System;

namespace MiJenner
{
    public static class MathUtils
    {
        /// <summary>
        /// RoundToSignificantDigits rounds a double to 'digits' significant digits. 
        /// </summary>
        /// <param name="d"></param>
        /// <param name="digits"></param>
        /// <returns></returns>
        /// Ref : https://stackoverflow.com/questions/374316/round-a-double-to-x-significant-figures/374470 

        public static double RoundToSignificantDigits(double d, int digits)
        {
            return double.Parse(d.ToString("G" + digits));
        }

        public static double TruncateToSignificantDigits(this double d, int digits)
        {
            bool isNeg = false; 
            if (d == 0)
                return 0;

            if (d < 0)
            {
                isNeg = true;
                d = -d; 
            }

            double scale = Math.Pow(10, Math.Floor(Math.Log10(Math.Abs(d))) + 1 - digits);
            if (isNeg)
            {
                d = -d;  
            }

            return scale * Math.Truncate(d / scale);
        }
    }
}