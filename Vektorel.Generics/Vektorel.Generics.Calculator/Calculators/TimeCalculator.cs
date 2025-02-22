using Vektorel.Generics.Calculator.Calculators.Base;

namespace Vektorel.Generics.Calculator.Calculators
{
    class TimeCalculator : ICalculator<TimeSpan>
    {
        public TimeSpan Add(TimeSpan value1, TimeSpan value2)
        {
            return value1 + value2;
        }

        public TimeSpan Subtract(TimeSpan value1, TimeSpan value2)
        {
           return value1 - value2;
        }
    }
}
