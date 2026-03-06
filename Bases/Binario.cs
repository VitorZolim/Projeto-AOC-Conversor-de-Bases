namespace Conversor.Bases
{
    internal class Binario : INumberBases
    {
        public double Mut { get; set; }
        public double Sum { get; set; }
        public double Result { get; set; }
        public HashSet<char> NumberValid { get; set; } = new HashSet<char> { '0', '1' };

        public string ConvertBinary(string value)
        {
            throw new NotImplementedException();
        }

        public string ConvertDecimal(string value) //Conversor de Binario para decimal
        {
            string[] N = value.Select(c => c.ToString()).ToArray(); // Separar caracter do value
            Array.Reverse(N); //Inverte possição dos numeros para ficar corresponde a sua elevação

            for (int i = 0; i < N.Length; i++)
            {
                Mut = Math.Pow(2, i) * int.Parse(N[i]);
                Sum += Mut;
                Result = Sum;
            }
            return Result.ToString(); // Lembrar de verificar questãqo de retorno de valores e aplicações
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
