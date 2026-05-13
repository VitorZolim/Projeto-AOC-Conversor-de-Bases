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
                    Console.WriteLine("Opção Inválida"); //Verificar se realmente precisa dessa mensagem
                    return null;
                    break;
            }
        }
    }
}
