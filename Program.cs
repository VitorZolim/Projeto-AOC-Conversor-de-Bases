using Conversor.Bases;

namespace Conversor;

public class Program
{
    public static void Main()
    {
        Decimal1 Calcule = new Decimal1();
        string Number = Console.ReadLine();

        Console.WriteLine(Calcule.CBinario(Number));
    }
}