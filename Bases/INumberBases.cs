namespace Conversor.Bases
{
    internal interface INumberBases
    {
        string[] NumberValid { get; set; }
        bool Validator(string value); //Ver como irá ser implementado e usado, deve verificar antes de criar a classe
        string ConvertBinary(string value);
        string ConvertDecimal(string value);
        string ConvertHexadecimal(string value);
        string ConvertOctal(string value);
        string ConvertFifth(string value);

        //Lembrar de implementar aqui caso novas implementaçoes forem feitas
    }
}
