namespace Conversor.Bases
{
    internal interface INumberBases
    {
        HashSet<char> NumberValid { get; set; } //Uso de HashSet, mais pratico que Array
        bool Validator(string value) //Verifica se o valor do User, é permitido para conversão
        {
            bool verificate = value.All(c => NumberValid.Contains(c));
            return verificate;
        }
        string ConvertBinary(string value);
        string ConvertDecimal(string value);
        string ConvertHexadecimal(string value);
        string ConvertOctal(string value);
        string ConvertFifth(string value);

        //Lembrar de adicionar aqui caso novas implementaçoes forem feitas
    }
}
