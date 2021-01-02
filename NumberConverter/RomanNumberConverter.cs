using System;
using System.Text;

namespace NumberConverter
{
    public static class RomanNumberConverter
    {
        private static char[] s_numberSymbols = {'I', 'X', 'C', 'M', 'V', 'L', 'D'};

        public static string RomanNumber(this int number)
        {
            if (number == default) return "NAN";
            int digitCount = 0, tempNum = number;
            StringBuilder sb = new StringBuilder();
            while (tempNum > 0)
            {
                tempNum /= 10;
                digitCount++;
            }
            if (digitCount>4)
            {
                digitCount = 4;
            }
            for (int i = digitCount; i > 0; i--)
            {
                int pow = (int) Math.Pow(10, i - 1);
                var digit = number / pow;
                number -= digit * pow;
                if (i < 4)
                {
                    switch (digit)
                    {
                        case 4:
                            sb.Append(s_numberSymbols[i - 1]).Append(s_numberSymbols[i + 3]);
                            continue;
                        case 5:
                            sb.Append(s_numberSymbols[i + 3]);
                            continue;
                        case 9:
                            sb.Append(s_numberSymbols[i - 1]).Append(s_numberSymbols[i]);
                            continue;
                    }

                    if (digit > 5 && digit<9)
                    {
                        sb.Append(s_numberSymbols[i + 3]);
                        digit -= 5;
                    }
                }
                for (int j = 0; j < digit; j++)
                {
                    sb.Append(s_numberSymbols[i - 1]);
                }

                if (number == default)
                    break;
            }

            return sb.ToString();
        }
    }
}