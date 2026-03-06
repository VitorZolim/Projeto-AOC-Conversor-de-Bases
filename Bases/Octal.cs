
namespace Conversor.Bases
{
    internal class Octal : INumberBases
    {
        public HashSet<char> NumberValid { get; set; } = new HashSet<char> { '0', '1', '2', '3', '4', '5', '6', '7' };

        public string ConvertBinary(string value)
        {
            throw new NotImplementedException();
        }

        public string ConvertDecimal(string value)
        {
            throw new NotImplementedException();
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
