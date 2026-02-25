namespace Conversor.Bases
{
    internal class Decimal1
    {
        public double Mut { get; set; }
        public double Sum { get; set; }
        public double Result { get; set; }

        public Decimal1() { }

        public double CBinario(string value) //Conversor de Binario para decimal
        {
            string[] N = value.Select(c => c.ToString()).ToArray(); // Separar caracter do value
            Array.Reverse(N); //Inverte possição dos numeros para ficar corresponde a sua elevação

            for (int i = 0; i < N.Length; i++)
            {
                Mut = Math.Pow(2, i) * int.Parse(N[i]);
                Sum += Mut;
                Result = Sum;
            }
            return Result; 
        }
    }
}
