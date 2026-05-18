using Conversor.Bases;
using Conversor.Engine;

namespace Conversor;

public class Program
{
    public static void Main()
    {
        //Variaveis de Entrada
        INumberBases MainBase; // Primeira Base, corresponde ao valor de entrada
        string Value;
        int CBase, n; // Segunda Base, corresponde a base a ser convertida

        int[] Bases = new int[5] { 2, 10, 16, 8, 5 }; //Validação
        Converter Operation = new Converter(); //Logica para inicio e conversão de bases

        while (true)
        {
            Console.WriteLine("--------Bases--------" +
                            "\n[2] [10] [16] [5] [8]" +
                            "\n[x] Finalizar\n");

            Console.Write("Base do Número: ");
            string option = Console.ReadLine();

            n = BaseSelect.SelectionInt(option); //Base do Número
            MainBase = BaseSelect.TypeNumeric(n);

            Console.Write("Número: ");
            Value = Console.ReadLine().ToUpper(); //Número para conversão
            BaseSelect.CloseProgram(Value);

            Console.Write("Base de Conversão: ");
            option = Console.ReadLine(); //Base para conversão
            CBase = BaseSelect.SelectionInt(option);

            if (MainBase != null && Bases.Contains(CBase) && MainBase.Validator(Value)) //Logica de validação geral - Verifica se os 3 valores são validos
            {
                Operation = new Converter(Value, CBase, MainBase); // Resultado instancia da classe permitida para calcular
                Console.WriteLine("Conversão: " + Operation.Calculate() + "\n");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\n[Entradas Invalídas tente novamente]\n");
            }
        }
    }
}