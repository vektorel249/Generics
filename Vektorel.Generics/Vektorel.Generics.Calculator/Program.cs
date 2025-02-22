using System.Drawing;
using Vektorel.Generics.Calculator.Calculators;
using Vektorel.Generics.Calculator.Calculators.Base;
using Vektorel.Generics.Calculator.Types;

namespace Vektorel.Generics.Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var c1 = new NumberCalculator();
            Console.WriteLine(c1.Add(3, 5));

            var c2 = new TextCalculator();
            Console.WriteLine(c2.Subtract("Caner", "er"));

            var c3 = new ColorCalculator();
            var newColor = c3.Add(Color.Red, Color.Yellow);
            Console.WriteLine($"{newColor.R},{newColor.G},{newColor.B}");

            Console.ReadKey();
            Console.Clear();


            //Factory Pattern

            var factory = new CalculatorFactory();
            var gc1 = factory.GetCalculator<TimeSpan>();
            var t1 = gc1.Add(TimeSpan.FromMinutes(75), TimeSpan.FromSeconds(1240));

            var gc2 = factory.GetCalculator<decimal>();
            var p1 = gc2.Add(3.45M, 123.67M);
        }
    }


    class CalculatorFactory
    {
        public ICalculator<T> GetCalculator<T>()
        {
            //typeof verilen generic parametrenin Type bilgisini okumamızı sağlar
            var type = typeof(T);
            switch (type.Name)
            {
                case "Int32":
                    return (ICalculator<T>)new NumberCalculator();
                case "String":
                    return (ICalculator<T>)new TextCalculator();
                case "Decimal":
                    return (ICalculator<T>)new PreciseCalculator();
                case "Field":
                    return (ICalculator<T>)new FieldCalculator();
                case "Color":
                    return (ICalculator<T>)new ColorCalculator();
                case "TimeSpan":
                    return (ICalculator<T>)new TimeCalculator();
            }
            throw new ArgumentException();
        }
    }
}
