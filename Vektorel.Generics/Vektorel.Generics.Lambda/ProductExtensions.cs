using Vektorel.Generics.Lambda.Models;

namespace Vektorel.Generics.Lambda
{
    // kasıtlı olrak "Static" yapıldı
    static class ProductExtensions
    {
        public static void Print(this List<Product> products)
        {
            foreach (var product in products)
            {
                Console.WriteLine("{0, 3} | {1, -31} | {2, -6} | {3, -5} | {4, -34} | {5, -15}", product.Id, product.Name, product.Price, product.Stock, product.Supplier, product.Category);
            }
        }
    }
}
