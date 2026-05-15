using Conversor.Engine;

namespace Conversor.Bases
{
    internal class Binario : INumberBases
    {
        public HashSet<char> NumberValid { get; set; } = new HashSet<char> { '0', '1' };

        public string ConvertBinary(string value)
        {
            return value;
        }

        public string ConvertDecimal(string value)
        {
            ulong Sum = 0, Result = 0;
            int digit;
            char[] chars = value.Reverse().ToArray();

            for (int i = 0; i < value.Length; i++)
            {
                digit = BaseSelect.ConvertDec(chars[i]);
                Sum += (ulong)(Math.Pow(2, i) * digit);
                Result = Sum;
            }
            return Result.ToString();
        }

        public string ConvertFifth(string value)
        {
            throw new NotImplementedException();
        }

        public string ConvertHexadecimal(string value)
        {
            throw new NotImplementedException();
        }

        public string ConvertOctal(string value)
        {
            throw new NotImplementedException();
        }
    }
}
