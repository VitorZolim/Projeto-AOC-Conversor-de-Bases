using Conversor.Bases;

namespace Conversor.Engine
{
    internal class Converter
    {
        public string NumberValue { get; set; }
        public int BaseConverted { get; set; }

        private INumberBases _numberBase;

        public Converter() { }
        public Converter(string numberValue, int baseConverted, INumberBases numberBase)
        {
            NumberValue = numberValue;
            BaseConverted = baseConverted;
            _numberBase = numberBase;
        }

        public string Calculate() //Operação final do Projeto retorno do valor convertido
        {
            if(BaseConverted == 2)
            {
                return _numberBase.ConvertBinary(NumberValue);
            }
            else if(BaseConverted == 10)
            {
                 return _numberBase.ConvertDecimal(NumberValue); 
            }
            else if(BaseConverted == 16)
            {
                return _numberBase.ConvertHexadecimal(NumberValue);
            }
            else if(BaseConverted == 8)
            {
                return _numberBase.ConvertOctal(NumberValue);
            }
            else if(BaseConverted == 5)
            {
                return _numberBase.ConvertFifth(NumberValue);
            }
            else
            {
                Console.WriteLine("Erro de Base Calculate");
                return null;
            }
        }
    }
}
