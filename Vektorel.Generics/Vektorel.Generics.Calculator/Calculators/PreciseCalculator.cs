using Vektorel.Generics.Calculator.Calculators.Base;

namespace Vektorel.Generics.Calculator.Calculators
{
    class PreciseCalculator : ICalculator<decimal>
    {
        public decimal Add(decimal value1, decimal value2)
        {
            return value1 + value2;
        }

        public decimal Subtract(decimal value1, decimal value2)
        {
            return value1 - value2;
        }
    }

}
