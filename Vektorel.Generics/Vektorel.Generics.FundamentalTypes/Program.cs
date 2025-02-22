using System.Collections;
using System.Drawing;

namespace Vektorel.Generics.FundamentalTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cities = new List<string>() { "İstanbul", "İzmir", "Ankara" };
            cities.Add("Ankara");
            Print(cities);

            List<int> numbers = new List<int>();
            numbers.Add(5);
            List<Product> products = new List<Product>();
            List<Random> randoms = new List<Random>();
            List<Color> colors = new List<Color>();
            colors.Add(Color.Red);

            //SortedSet
            //SortedList
            //SortedDictionary
            

            HashSet<string> fruits = new HashSet<string>();
            fruits.Add("Elma");
            fruits.Add("Armut");
            fruits.Add("Elma");
            fruits.Add("Kiraz");
            Print(fruits);
            Print("Can");
            //Print(4);

            Dictionary<int, string> numberDefinitions = new Dictionary<int, string>();
            numberDefinitions.Add(1, "Bir");
            numberDefinitions.Add(2, "İki");
            numberDefinitions.Add(3, "Üç");
            numberDefinitions.Add(4, "Dört");
            numberDefinitions.Add(5, "Beş");

            Dictionary<string, HashSet<string>> dictionary = new Dictionary<string, HashSet<string>>();
            dictionary.Add("book", new HashSet<string>() { "Kitap", "Ayırmak, rezerve etmek", "Kitap" });
            dictionary.Add("get", new HashSet<string>() { "Almak", "Okumak", "Sahip Olmak" });
            dictionary.Add("key", new HashSet<string>() { "Anahtar", "Şifre", "Özel bilgi", "Güvenlik terimi" });
            PrintDictionary(dictionary);

            //FIFO: First In First Out
            Queue<Person> people = new Queue<Person>();
            people.Enqueue(new Person("Can"));
            people.Enqueue(new Person("Uğur"));
            people.Enqueue(new Person("Arda"));
            people.Enqueue(new Person("Gürkan"));
            people.Enqueue(new Person("Murat"));
            people.Enqueue(new Person("Mücahit"));
            Print(people);

            people.Dequeue();
            people.Dequeue();
            Print(people);

            //LIFO: Last In First Out
            //Stack

            //ÖDEV
            //Chain of Responsibility Pattern
            //verilen baknota göre tutar üzerinden en mantıklı para üstü verme algoritması
            //200 TL alınan paradan 40 TL alınacak. 160 TL kasadaki olasılıklarda en mantıklı nasıl verilmeli
        }

        static void Print<T>(IEnumerable<T> values)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Printing {typeof(T).Name}");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (T value in values)
            {
                Console.WriteLine(value);
            }
        }

        static void PrintDictionary(Dictionary<string, HashSet<string>> dictionary)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Printing Dictionary");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var item in dictionary)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"{item.Key} : ");
                Console.ForegroundColor = ConsoleColor.Gray;
                foreach (var value in item.Value)
                {
                    Console.WriteLine($"\t{value}");
                }
            }
        }

        class Product
        {

        }

        class Person
        {
            public Person(string fullName)
            {
                FullName = fullName;
            }

            public string FullName { get; set; }

            public override string ToString()
            {
                return FullName;
            }
        }
    }
}