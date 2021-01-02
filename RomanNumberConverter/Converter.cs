using System;
using System.Text;

namespace RomanNumberConverter
{
    public static class RomanNumberConverter
    {
        private static char[] s_numberSymbols = {'I','X','C','M'};
        private static string RomanNumber(this int number)
        {
            StringBuilder sb = new StringBuilder();
            if (number == default) return "NAN";
            int digitCount=0, tempNum=number;
            
            while (tempNum>0)
            {
                tempNum /= 10;
                digitCount++;
            }
            
            for (int i = digitCount; i > 0; i--)
            {
                var digit = number / Math.Pow(10, i - 1);
                for (int j = 0; j < digit; j++)
                {
                    sb.Append(s_numberSymbols[i]);
                }
            }
            return sb.ToString();
        }
    }
}