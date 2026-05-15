using Conversor.Bases;

namespace Conversor.Engine
{
    internal static class BaseSelect
    {
        public static INumberBases TypeNumeric(int option) //Decide o tipo da base principal do número retornando a classe correspondente
        {
            switch (option)
            {
                case 2:
                    return new Binario();
                    break;
                case 10:
                    return new BaseDecimal();
                    break;
                case 16:
                    return new Hexadecimal(); 
                    break;
                case 8:
                    return new Octal(); 
                    break;
                case 5:
                    return new Fifth(); 
                    break;
                default:
                    return null;
                    break;
            }
        }
        public static int ConvertHex(char L)
        {
            int HexNum = (int)L - 55;
            return HexNum;
        }
        public static char ConvertHex(int N)
        {
            int HexNum = N + 55;
            return (char)HexNum;
        }
        public static int ConvertDec(char N)
        {
            int DecNum = (int)N - 48;
            return DecNum;
        }
    }
}
