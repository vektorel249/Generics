using Vektorel.Generics.Lambda.Dtos;
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
            Console.WriteLine("  6 - A ile Başlayan Ürünlerin Adı ve Fiyatı");
            Console.WriteLine("  7 - Kategoriye Göre Ürün Sayısı");
            Console.WriteLine("  8 - Kategoriye Göre Ürün İsimleri");
            Console.WriteLine("  9 - Fiyatı 50 Üstü olan ve Kıyafet Olanlar");
            Console.WriteLine(" 10 - Mutfak kategorisindeki ürünlerin tedarikçisine göre ayrıştırılması");
            Console.WriteLine(" 11 - Fiyatı 50 üstü olan ürün sayısı");
            Console.WriteLine(" 12 - İçecekleri Stoktaki Değerlere Göre Fiyat Toplamı");
            Console.WriteLine(" 13 - En pahalı Ürün");
            Console.WriteLine(" 14 - Fiyatlara %8 Zam Yansıtılması ve Eski Fiyat Yeni Fiyat Gösterimi");
            Console.WriteLine(" 15 - %8 Zam Yansıtılması Sonucunda Elde Edilecek Toplam Gelir");
            Console.WriteLine(" 16 - Stokta En Çok Bulunan 5 Ürün");
            Console.WriteLine(" 17 - 15 Adet Altı Ürünleri 50'ye Yükseltme Halinde Gereken Yatırım (Tablo)");
            Console.WriteLine(" 18 - Her Kategorideki En Pahalı Ürün");

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
                case "7":
                    CountByCategory(repository);
                    break;
                case "8":
                    ProductsByCategory(repository);
                    break;
                case "9":
                    ClothesThatAreMoreThan50Liras(repository);
                    break;
                case "10":
                    KitchenSuffBySupplier(repository);
                    break;
                case "11":
                    CountByPriceThatMoreThan50Liras(repository);
                    break;
                case "12":
                    TotalPriceForBeverages(repository);
                    break;
                case "13":
                    MostExpensiveProduct(repository);
                    break;
                case "14":
                    IncreasePriceBy8Percentage(repository);
                    break;
                case "16":
                    TopFiveProductsInStock(repository);
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

            public bool FindDataByName(string name)
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

        private static void IncreasePriceBy8Percentage(ProductRepository repository)
        {
            repository.Products.Select(s => new IncreasePriceProductDto
                                {
                                    Name = s.Name,
                                    OldPrice = s.Price,
                                    NewPrice = Math.Round(s.Price * 1.08M, 2),
                                })
                                .ToList()
                                .Print();
        }

        private static void MostExpensiveProduct(ProductRepository repository)
        {
            repository.Products.OrderByDescending(o => o.Price)
                               .Take(1)
                               .First()
                               .Print();
        }

        private static void TopFiveProductsInStock(ProductRepository repository)
        {
            repository.Products.OrderByDescending(o => o.Stock)
                               .Take(5)
                               .ToList()
                               .Print();
        }

        private static void TotalPriceForBeverages(ProductRepository repository)
        {
            //var total = repository.Products.Where(p => p.Category == "Beverages")
            //                               .Sum(p => p.Stock * p.Price);
            var total = repository.Products.Where(p => p.Category == "Beverages")
                                           .Sum(p => Math.Round(p.Stock * p.Price, 2, MidpointRounding.AwayFromZero));
            Console.WriteLine($"Depoda toplam {total} liralık içecek mevcut");
        }

        private static void CountByPriceThatMoreThan50Liras(ProductRepository repository)
        {
            //var count = repository.Products.Where(p => p.Price > 50).Count();
            var count = repository.Products.Count(p => p.Price > 50);
            Console.WriteLine($"Toplam {count} adet ürün 50 TL üstünde");
        }

        private static void KitchenSuffBySupplier(ProductRepository repository)
        {
            repository.Products.Where(p => p.Category == "Kitchen")
                               .GroupBy(g => g.Supplier)
                               .Select(s => new ProductsBySupplierDto
                               {
                                   Name = s.Key,
                                   Products = s.Select(p => new SupplierProductDto
                                   {
                                       Name = p.Name,
                                       Price = p.Price,
                                       Stock = p.Stock,
                                   }).ToList()
                               })
                               .ToList()
                               .Print();
        }

        private static void ClothesThatAreMoreThan50Liras(ProductRepository repository)
        {
            repository.Products.Where(p => p.Price > 50 && p.Category == "Clothes")
                               .ToList()
                               .Print();
        }

        private static void ProductsByCategory(ProductRepository repository)
        {
            repository.Products.GroupBy(p => p.Category)
                               .Select(p => new ProductsByCategoryDto
                               {
                                   Name = p.Key,
                                   Products = string.Join(", ", p.Select(s => s.Name))
                               })
                               .ToList()
                               .Print();
        }

        private static void CountByCategory(ProductRepository repository)
        {
            repository.Products.GroupBy(p => p.Category)
                               .Select(p => new CountByCategoryDto
                               {
                                   Category = p.Key,
                                   Count = p.Count()
                               })
                               .ToList()
                               .Print();
        }

        private static void JustNameAndPriceThatStartsWithA(ProductRepository repository)
        {
            var products = repository.Products.Where(p => p.Name.ToLower().StartsWith("a"))
                                              .Select(s => new BasicProductDto
                                              {
                                                  Name = s.Name,
                                                  Price = s.Price,
                                              })
                                              .OrderBy(o => o.Name)
                                              .ToList();

            products.Print();

            /*
             public BasicProductDto Map(Product p)
             {
                 return new BasicProductDto 
                 {
                     Name = p.Name,
                     Price = p.Price * 1.05
                 };
             }
             */
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
