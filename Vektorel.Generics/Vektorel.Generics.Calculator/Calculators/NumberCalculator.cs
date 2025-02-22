using Vektorel.Generics.Calculator.Calculators.Base;

namespace Vektorel.Generics.Calculator.Calculators
{
    class NumberCalculator : ICalculator<int>
    {
        public int Add(int value1, int value2)
        {
            return value1 + value2;
        }

        public int Subtract(int value1, int value2)
        {
            return value1 - value2;
        }
    }

}
