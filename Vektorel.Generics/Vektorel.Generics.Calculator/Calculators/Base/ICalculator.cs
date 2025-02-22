namespace Vektorel.Generics.Calculator.Calculators.Base
{
    interface ICalculator<T>
    {
        T Add(T value1, T value2);
        T Subtract(T value1, T value2);
    }

}
