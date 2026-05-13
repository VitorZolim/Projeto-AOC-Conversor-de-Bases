using Conversor.Bases;
using Conversor.Engine;

namespace Conversor;

public class Program
{
    public static void Main()
    {
        Converter Operation = new Converter(); //Logica para inicio e conversão de bases
        int[] Bases = new int[5] { 2, 10, 16, 8, 5 }; //Bases possiveis para conversão
        //Valores:
        INumberBases MainBase; // Primeira Base, corresponde ao valor de entrada
        int CBase; // Segunda Base, corresponde a base a ser convertida
        string Value; //Valor de entrada

        while (true)
        {
            //if(Value.ToUpper() != "x") { break; } Alguma lógica para finalizar o programa

            //Entradas do usuario
            int v = int.Parse(Console.ReadLine());
            MainBase = BaseSelect.TypeNumeric(v);
            Value = Console.ReadLine();
            CBase = int.Parse(Console.ReadLine());
            
            if (MainBase != null && Bases.Contains(CBase) && MainBase.Validator(Value)) //Logica de validação geral - Verifica se os 3 valores são validos
            {
                Operation = new Converter(Value, CBase, MainBase); // Resultado instancia da classe permitida para calcular
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\n[Entradas Invalídas tente novamente]\n");
            }
        }
    }
}