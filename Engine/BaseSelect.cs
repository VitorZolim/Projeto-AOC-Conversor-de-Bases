using Conversor.Bases;

namespace Conversor.Engine
{
    internal class BaseSelect
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
                    return new Hexadecimal(); // Implementar interface na classe
                    break;
                case 8:
                    return new Octal(); // Implementar interface na classe
                    break;
                case 5:
                    return new Fifth(); // Implementar interface na classe
                    break;
                default:
                    Console.WriteLine("Opção Inválida");
                    return null;
                    break;
            }
        }
    }
}
