using Conversor.Engine;
using System.Text;

namespace Conversor.Bases
{
    internal class BaseDecimal : INumberBases
    {
        public HashSet<char> NumberValid { get; set; } = new HashSet<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};

        public string ConvertBinary(string value)
        {
            ulong value2 = ulong.Parse(value);
            StringBuilder sr = new StringBuilder();
            do
            {
                sr.Append(value2 % 2);
                value2 /= 2;
            } while (value2 > 0);

            char[] invert = sr.ToString().ToCharArray();
            Array.Reverse(invert);

            return invert.ToString();
        }

        public string ConvertDecimal(string value)
        {
            return value;
        }

        public string ConvertFifth(string value)
        {
            ulong value2 = ulong.Parse(value);
            StringBuilder sr = new StringBuilder();
            do
            {
                sr.Append(value2 % 5);
                value2 /= 5;
            } while (value2 > 0);

            char[] invert = sr.ToString().ToCharArray();
            Array.Reverse(invert);

            return invert.ToString();
        }

        public string ConvertHexadecimal(string value)
        {
            ulong value2 = ulong.Parse(value);
            StringBuilder sr = new StringBuilder();
            do
            {
                int x = (int)(value2 % 16);
                if (x >= 10)
                {
                    sr.Append(BaseSelect.ConvertHex(x));
                }
                else
                {
                    sr.Append(x);
                }
                value2 /= 16;
            }while (value2 > 0);

            char[] invert = sr.ToString().ToCharArray();
            Array.Reverse(invert);

            return invert.ToString();
        }

        public string ConvertOctal(string value)
        {
            ulong value2 = ulong.Parse(value);
            StringBuilder sr = new StringBuilder();
            do
            {
                sr.Append(value2 % 8);
                value2 /= 8;
            } while (value2 > 0);

            char[] invert = sr.ToString().ToCharArray();
            Array.Reverse(invert);

            return invert.ToString();
        }
    }
}
