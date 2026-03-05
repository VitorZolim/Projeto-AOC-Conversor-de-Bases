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

        public double Calculate() //verificar retorno dos valores
        {
            if(BaseConverted == 2)
            {
                // return _numberBase.ConvertBinary(NumberValue); //verificar formas de retorno de valor
            }
            else if(BaseConverted == 10)
            {
                 // return _numberBase.ConvertDecimal(NumberValue); // Mesmo problema do de cima e faltando implementar mais as outras bases
            }
                return 0;
        }
    }
}
