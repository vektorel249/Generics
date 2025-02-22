using Vektorel.Generics.Calculator.Calculators.Base;

namespace Vektorel.Generics.Calculator.Calculators
{
    class TextCalculator : ICalculator<string>
    {
        public string Add(string value1, string value2)
        {
            return string.Concat(value1, value2);
        }

        public string Subtract(string value1, string value2)
        {
            return value1.Replace(value2, string.Empty);
        }
    }

}
