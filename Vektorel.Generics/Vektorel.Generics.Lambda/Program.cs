using Vektorel.Generics.Lambda.Models;
using Vektorel.Generics.Lambda.Repositories;

namespace Vektorel.Generics.Lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // KONU: System.Linq namespace
            // Expression
            // Action
            // Function
            //    => Delegate
            //    => Builder Pattern
            var repository = new ProductRepository();
            Console.WriteLine($"Toplam Ürün Sayısı : {repository.Products.Count}");

            Console.WriteLine("İşlemi seçiniz");
            Console.WriteLine("  1 - Tüm Ürünler");
            Console.WriteLine("  2 - 10 TL altındaki ürünler");
            Console.WriteLine("  3 - İçecekler");
            Console.WriteLine("  4 - Stokta Olmayanlar (Ada Göre Sıralı)");
            Console.WriteLine("  5 - Kritik Seviyede Stokta Olanlar");

            var code = Console.ReadLine();
            switch (code)
            {
                case "1":
                    AllProducst(repository);
                    break;
                case "2":
                    ProductsUnder10Liras(repository);
                    break;
                case "3":
                    Beverages(repository);
                    break;
                case "4":
                    OutOfStockOrdered(repository);
                    break;
                case "5":
                    CriticalStock(repository);
                    break;
                case "6":
                    JustNameAndPriceThatStartsWithA(repository);
                    break;
                default:
                    Console.WriteLine("Yanlış Seçim");
                    break;
            }

            #region Implicit Operatör
            var person1 = new Person { FirstName = "Can", LastName = "Perk" };
            Person person2 = "Can Perk";
            #endregion

            #region Func Tanımı
            //Func<TSource, bool> predicate
            /*
            Örnek: Func<string, bool> function

            -------> Func ifadesi return type function delagate demek. son generic parametre return type, 
                     öncekiler ise sırasıyla method in parametereleri

            public bool Find(string name)
            {
                bazı kodlar
                name ile bir şeyler
                if(c)
                   return true;
                return false;
            }
             */

            var func = FindDataByName;

            var a = func("Can", 37);
            #endregion

            #region Linq To Entities
            /*
            
             var productList = from p in repository.Products
                               where p.Price > 100
                               select p;
             */
            #endregion
        }

        private static void JustNameAndPriceThatStartsWithA(ProductRepository repository)
        {
            var products = repository.Products.Where(p => p.Name.ToLower().StartsWith("a"));
        }

        private static void CriticalStock(ProductRepository repository)
        {
            repository.Products.Where(p => p.Stock > 0 && p.Stock <= 15)
                               .OrderByDescending(o => o.Stock)
                               .ThenBy(o => o.Name)
                               .ToList()
                               .Print();
        }

        private static void OutOfStockOrdered(ProductRepository repository)
        {
            var outOfStock = repository.Products
                                       .Where(p => p.Stock == 0)
                                       .OrderBy(p => p.Name);

            outOfStock.ToList().Print();
        }

        private static void Beverages(ProductRepository repository)
        {
            var beverages = repository.Products.Where(product => product.Category == "Beverages");

            beverages.ToList().Print();
        }

        private static void ProductsUnder10Liras(ProductRepository repository)
        {
            var cheapProducts = repository.Products.Where(FindProduct).ToList();

            bool FindProduct(Product product)
            {
                return product.Price < 10;
            }

            cheapProducts.Print();
        }

        private static void AllProducst(ProductRepository repository)
        {
            repository.Products.Print();

           
        }

        public static bool FindDataByName(string name, int age)
        {
            return name == "Can";
        }
    }
}
