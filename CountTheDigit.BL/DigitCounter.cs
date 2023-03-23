using System;
using System.Globalization;
using System.Reflection.Metadata;
using System.Linq;

namespace CountTheDigit.BL
{
    public class DigitCounter : IDigitCounter
    {
        public int NbDig(int n, int d)
        {
            int count = 0;

            for (int i = 0; i <= n; i++)
            {
                string numbers = (i*i).ToString();

                count += numbers.Count(x => x.ToString() == d.ToString());
            }
            return count;
        }
    }
}
