using Vektorel.Generics.Calculator.Calculators.Base;
using Vektorel.Generics.Calculator.Types;

namespace Vektorel.Generics.Calculator.Calculators
{
    class FieldCalculator : ICalculator<Field>
    {
        public Field Add(Field value1, Field value2)
        {
            return new Field
            {
                Width = value1.Width + value2.Width,
                Length = value1.Length + value2.Length
            };
        }

        public Field Subtract(Field value1, Field value2)
        {
            return new Field
            {
                Width = value1.Width - value2.Width,
                Length = value1.Length - value2.Length
            };
        }
    }

}
