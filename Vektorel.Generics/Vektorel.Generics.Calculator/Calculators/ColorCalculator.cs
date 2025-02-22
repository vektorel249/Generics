using System.Drawing;
using Vektorel.Generics.Calculator.Calculators.Base;

namespace Vektorel.Generics.Calculator.Calculators
{
    class ColorCalculator : ICalculator<Color>
    {
        public Color Add(Color value1, Color value2)
        {
            int r = (value1.R + value2.R) / 2;
            int g = (value1.G + value2.G) / 2;
            int b = (value1.B + value2.B) / 2;
            int a = Math.Min(value1.A, value2.A);

            return Color.FromArgb(a, r, g, b);
        }

        public Color Subtract(Color value1, Color value2)
        {
            int r = Math.Max(value1.R - value2.R, 0);
            int g = Math.Max(value1.G - value2.G, 0);
            int b = Math.Max(value1.B - value2.B, 0);
            int a = Math.Max(value1.A - value2.A, 0);

            return Color.FromArgb(a, r, g, b);
        }
    }

}
