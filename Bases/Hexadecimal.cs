
using Conversor.Engine;

namespace Conversor.Bases
{
    internal class Hexadecimal : INumberBases
    {
        public HashSet<char> NumberValid { get; set; } = new HashSet<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

        public string ConvertBinary(string value)
        {
            value = ConvertDecimal(value);
            BaseDecimal Base10 = new BaseDecimal();
            value = Base10.ConvertBinary(value);
            return value;
        }

        public string ConvertDecimal(string value)
        {
            ulong Sum = 0,Pow = 1, Result = 0;
            int digit;
            char[] chars = value.Reverse().ToArray();

            for (int i = 0; i < value.Length; i++)
            {
                if (chars[i] >= 'A' && chars[i] <= 'F')
                {
                    digit = BaseSelect.ConvertHex(chars[i]);
                }
                else
                {
                    digit = BaseSelect.ConvertDec(chars[i]);
                }
                for (int j = 0; j < i; j++)
                {
                    Pow *= 16;
                }
                Sum += Pow * (ulong)digit;
                Result = Sum;
                Pow = 1;
            }
            return Result.ToString();
        }

        public string ConvertFifth(string value)
        {
            value = ConvertDecimal(value);
            BaseDecimal Base10 = new BaseDecimal();
            value = Base10.ConvertFifth(value);
            return value;
        }

        public string ConvertHexadecimal(string value)
        {
            return value;
        }

        public string ConvertOctal(string value)
        {
            value = ConvertDecimal(value);
            BaseDecimal Base10 = new BaseDecimal();
            value = Base10.ConvertOctal(value);
            return value;
        }
    }
}
