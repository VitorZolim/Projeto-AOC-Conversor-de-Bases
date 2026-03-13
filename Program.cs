using Conversor.Bases;
using Conversor.Engine;

namespace Conversor;

public class Program
{
    public static void Main()
    {
        Converter Operation = new Converter(); //Logica para inicio e conversão de bases
        
        int[] Bases = new int[5] { 2, 10, 16, 8, 5 }; //Bases possiveis para conversão

        //Entradas do usuario
        INumberBases MainBase; // Primeira Base, corresponde ao valor de entrada
        int CBase; // Segunda Base, corresponde a base a ser convertida
        string Value; // Valor de entrada

        if (MainBase != null && Bases.Contains(CBase) && MainBase.Validator(Value)) // Logica de validação geral - Verifica se os 3 valores são validos
        {
            Operation = new Converter(MainBase, CBase, Value); // Resultado instancia da classe permitida para calcular
        }

        Console.WriteLine();
    }
}