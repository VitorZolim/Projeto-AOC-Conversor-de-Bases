using Conversor.Bases;

namespace Conversor.Engine
{
    internal static class BaseSelect
    {
        public static INumberBases TypeNumeric(int option)
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
                    Console.WriteLine("Opção Inválida");
                    return null;
                    break;
            }
        }
    }
}
