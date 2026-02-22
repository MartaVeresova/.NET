using System.Linq;
using System.Threading.Channels;

namespace Practice
{
    internal class Example
    {

        static void Main(string[] args)
        {
            // Домашнее задание (уроки 9-10)
            // 1. Работа с числами (LINQ):

            List<int> numbers = new List<int> { 5, 12, 7, 20, 33, 18, 2, 40 };

            Console.WriteLine("Задание 1:");
            var tripledNumbers = numbers.Where(n => n % 2 == 0).OrderBy(n => n).Select(n => n * 3);
            foreach (var num in tripledNumbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("\n");


            // 2. Фильтрация объектов (LINQ):

            List<Product> product = new List<Product>() {
                new Product("Банан", 68.5, 10),
                new Product("Апельсин", 112.4, 4),
                new Product("Памело", 154.2, 2),
                new Product("Помидор", 101.6, 7),
                new Product("Огурец", 97.1, 6),
            };

            Console.WriteLine("Задание 2:");
            var productsName = product.Where<Product>(p => p.Price > 100).OrderByDescending(p => p.Price).Select(p => p.Name);
            foreach (var prod in productsName)
            {
                Console.WriteLine(prod);
            }
            Console.WriteLine("\n");


            // 3. Проверки (LINQ):

            List<Student> students = new List<Student>() {
                new Student {Grade = 5 },
                new Student {Grade = 3 },
                new Student {Grade = 3 },
                new Student {Grade = 4 },
                new Student {Grade = 2 },
                new Student {Grade = 5 },
            };

            Console.WriteLine("Задание 3.1:");
            var hasBadStudent = students.Any<Student>(s => s.Grade < 3);
            Console.WriteLine(hasBadStudent);
            Console.WriteLine("\n");

            Console.WriteLine("Задание 3.2:");
            var hasGoodStudent = students.All<Student>(s => s.Grade >= 4);
            Console.WriteLine(hasGoodStudent);
            Console.WriteLine("\n");

            Console.WriteLine("Задание 3.3:");
            var goodStudentsCount = students.Count<Student>(s => s.Grade > 4);
            Console.WriteLine(goodStudentsCount);
            Console.WriteLine("\n");


            // 4. Агрегация  (LINQ):

            Console.WriteLine("Задание 4.1:");
            int sumEven = numbers.Aggregate(0, (acc, n) => n % 2 == 0 ? acc + n : acc);
            Console.WriteLine(sumEven);
            Console.WriteLine("\n");

            Console.WriteLine("Задание 4.2:");
            int max = numbers.Aggregate((x, y) => x > y ? x : y);
            Console.WriteLine(max);
            Console.WriteLine("\n");

            Console.WriteLine("Задание 4.3:");
            double average = numbers.Aggregate(
                0.0,
                (acc, n) => acc + n,
                acc => acc / numbers.Count
                );
            Console.WriteLine(average);
            Console.WriteLine("\n");


            // 5. Группировка (LINQ):

            Console.WriteLine("Задание 5.1:");
            var groupable = numbers.GroupBy(n => n % 2 == 0 ? "Четные" : "Нечетные");
            foreach (var num in groupable)
            {
                Console.WriteLine(num.Key + ": " + string.Join(", ", num));
            }
            Console.WriteLine("\n");


            // 6. Фильтрация объектов (LINQ):

            List<Person> persons = new List<Person>() {
                new Person("Marat", 16),
                new Person("Vika", 19),
                new Person("Olga", 21),
                new Person("Viktor", 18),
                new Person("Lion", 28),
            };

            Console.WriteLine("Задание 6.1:");
            var adults = persons.Where(p => p.Age >= 18).OrderBy(p => p.Age);
            foreach (var person in adults)
            {
                Console.WriteLine(person.Name);
            }
            Console.WriteLine("\n");


            // 7. Поиск (LINQ):

            Console.WriteLine("Задание 7.1:");
            var firstPerson = persons.FirstOrDefault(p => p.Age > 30);
            Console.WriteLine(firstPerson != null ? firstPerson.Name : "Такого нет");
            Console.WriteLine("\n");

            // 8. Проверки (LINQ):

            Console.WriteLine("Задание 8.1:");
            var young = persons.Any(p => p.Age < 25);
            Console.WriteLine(young);
            Console.WriteLine("\n");

            Console.WriteLine("Задание 8.2:");
            var hasAdult = persons.All(p => p.Age >= 18);
            Console.WriteLine(hasAdult);
            Console.WriteLine("\n");

            // 9. Фильтрация строк (LINQ):

            List<string> words = new() { "Artem", "Natali", "Yana", "Yulia", "Alex" };

            Console.WriteLine("Задание 9.1:");
            var longWords = words.Where(w => w.Length > 4).OrderBy(w => w);
            foreach (var word in longWords)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine("\n");


            // 10. Поиск подстрок (LINQ):

            Console.WriteLine("Задание 10.1:");
            var filteredWords = words.Where(w => w.Contains("a")).Select(w => w.ToUpper());
            foreach (var word in filteredWords)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine("\n");


            // 11. Уникальные элементы (LINQ):

            Console.WriteLine("Задание 11:");
            var nums = new List<int>() { 3, 15, 12, 4, 3, 10, 4, 11, 17, 24, 12 };
            var uniq = nums.Distinct().OrderByDescending(n => n);
            foreach (var num in uniq)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("\n");


            // 12. Вложенные коллекции (LINQ):

            List<Order> orders = new List<Order>() {
                new Order { Id = 1, Prices = new List<int>() {120, 130, 150, 170} },
                new Order { Id = 2, Prices = new List<int>() {150, 180, 190, 220} },
            };

            Console.WriteLine("Задание 12.1:");
            var prices = orders.SelectMany(o => o.Prices).ToList();
            foreach (var num in prices)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("\n");

            Console.WriteLine("Задание 12.2:");
            var maxPrice = prices.Max();
            Console.WriteLine(maxPrice);
            Console.WriteLine("\n");


            // 13. Action с объектом:

            Console.WriteLine("Задание 13:");
            var user = new User { Name = "Алексей", Age = 28 };

            Action<User> printUser = user =>
            {
                Console.WriteLine($"Имя: {user.Name}, Возраст: {user.Age}");
            };

            printUser(user);
            Console.WriteLine("\n");

            // 14. Action — выполнение действия:

            Console.WriteLine("Задание 14:");

            Action<string> printUpper = str =>
            {
                Console.WriteLine(str.ToUpper());
            };
            printUpper("Вывод строки в верхнем регистре");
            Console.WriteLine("\n");

            // 15. Func с несколькими параметрами:

            Console.WriteLine("Задание 15:");

            Func<double, double, double> printAverage = (a, b) => (a + b) / 2.0;

            double averageRes = printAverage(12.5, 14.3);
            Console.WriteLine(averageRes);
            Console.WriteLine("\n");
        }


    }

    // 2. Фильтрация объектов (LINQ):
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
    }

    // 3. Проверки (LINQ):
    class Student
    {
        public int Grade { get; set; }
    }

    // 6. Фильтрация объектов (LINQ):
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    // 12. Вложенные коллекции (LINQ):
    class Order
    {
        public int Id { get; set; }
        public List<int> Prices { get; set; }
    }

    // 13. Action с объектом:
    class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

}