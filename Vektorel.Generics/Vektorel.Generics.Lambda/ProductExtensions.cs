using Vektorel.Generics.Lambda.Dtos;
using Vektorel.Generics.Lambda.Models;

namespace Vektorel.Generics.Lambda
{
    // kasıtlı olrak "Static" yapıldı
    static class ProductExtensions
    {
        //this kullanımına dikkat!!!!!
        public static void Print(this List<Product> products)
        {
            foreach (var product in products)
            {
                Console.WriteLine("{0, 3} | {1, -31} | {2, -6} | {3, -5} | {4, -34} | {5, -15}", product.Id, product.Name, product.Price, product.Stock, product.Supplier, product.Category);
            }
        }

        public static void Print(this List<BasicProductDto> products)
        {
            foreach (var product in products)
            {
                Console.WriteLine("{0, -31} | {1, -6}", product.Name, product.Price);
            }
        }
        
        public static void Print(this List<CountByCategoryDto> categories)
        {
            foreach (var category in categories)
            {
                Console.WriteLine("{0, -15} | {1, -6}", category.Category, category.Count);
            }
        }
        
        public static void Print(this List<ProductsByCategoryDto> categories)
        {
            foreach (var category in categories)
            {
                Console.WriteLine("{0, -15} | {1}", category.Name, category.Products);
            }
        }
        
        public static void Print(this List<ProductsBySupplierDto> suppliers)
        {
            foreach (var supplier in suppliers)
            {
                Console.WriteLine($"=== {supplier.Name}");
                foreach (var product in supplier.Products)
                {
                    Console.WriteLine("    {0, -31} | {1, -6} | {2}", product.Name, product.Price, product.Stock);
                }
                
            }
        }
    }
}
