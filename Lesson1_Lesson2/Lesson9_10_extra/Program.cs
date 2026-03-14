using Lesson9_10_extra;
using Lesson9_10_extra.User;
using static System.Reflection.Metadata.BlobBuilder;
using Developer = Lesson9_10_extra.Company.Developer;
using HR = Lesson9_10_extra.Company.HR;

namespace Practice
{
    internal class Example
    {

        static void Main(string[] args)
        {
            // Домашнее задание (повтор тем)
            // 1. Преобразование базовых типов данных:
            Console.WriteLine("Задание 1:");

            Console.WriteLine("Введите число с плавающей точкой (запятой):");
            var input = Console.ReadLine().Replace('.', ',');

            if (double.TryParse(input, out double result))
            {
                double doub = Convert.ToDouble(input);
                Console.WriteLine(Math.Round(doub * 2, 2).ToString());
            }
            else
            {
                Console.WriteLine("Введите корректное значение");
            }

            Console.WriteLine("\n");


            // 2. Массивы:
            Console.WriteLine("Задание 2:");

            int[] ArrayHelper(int[] arr)
            {
                var max = arr.Max(x => x);
                var min = arr.Min(x => x);

                Console.WriteLine($"Максимальное значение - {max}, Минимальное значение - {min}");

                var average = arr.Average();
                var newArr = arr.Where<int>(n => n > average).ToArray();
                return newArr;
            }

            var numbers = new[] { 2, 4, 7, 15, 1, 5, 3 };
            var newArr = ArrayHelper(numbers);

            foreach (var n in newArr)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("\n");

            // 3. Символы и строки:
            Console.WriteLine("Задание 3:");

            Console.WriteLine("Напишите предложение:");
            var stringInput = Console.ReadLine();
            var vowels = "аеёиоуыэюя";
            var count = stringInput.Count(l => vowels.Contains(l.ToString().ToLower()));
            Console.WriteLine(count);

            var modified = stringInput.Replace(' ', '_');
            Console.WriteLine(modified);

            var reversed = stringInput.ToCharArray().Reverse().ToArray();
            var reversedStr = new string(reversed);
            Console.WriteLine(reversedStr);

            Console.WriteLine("\n");


            // 4. Методы:
            Console.WriteLine("Задание 4:");

            var res1 = MathUtils.Calculate(25, 5, Operation.Sum);
            var res2 = MathUtils.Calculate(25, 5, Operation.Sub);
            var res3 = MathUtils.Calculate(25, 5, Operation.Mul);
            var res4 = MathUtils.Calculate(25, 5, Operation.Div);

            Console.WriteLine(res1);
            Console.WriteLine(res2);
            Console.WriteLine(res3);
            Console.WriteLine(res4);

            Console.WriteLine("\n");


            // 5. Enums (Перечисления):
            Console.WriteLine("Задание 5:");

            string GetAction(TrafficLight light)
            {
                switch (light)
                {
                    case TrafficLight.Red:
                        return "Красный, не идём";
                    case TrafficLight.Yellow:
                        return "Жёлтый, ожидаем";
                    case TrafficLight.Green:
                        return "Зелёный, можно идти";
                    default:
                        return "";
                }
            }

            Console.WriteLine(GetAction(TrafficLight.Green));

            Console.WriteLine("\n");


            // 6. Классы:
            Console.WriteLine("Задание 6:");

            Book book1 = new Book("10 негритят", "Агата Кристи", 1986, true);
            Book book2 = new Book("Маленький принц", "Антуан де Сент-Экзюпери", 1967, false);
            Book book3 = new Book("Мизери", "Стивен Кинг", 2019, false);

            book1.Borrow();
            book1.Borrow();
            book1.Return();
            book1.Borrow();

            Console.WriteLine("\n");


            // 7. Перегрузка
            Console.WriteLine("Задание 7:");

            Printer printer = new Printer();
            printer.Print("Документ отправлен на печать");
            printer.Print("Документ отправлен на печать", 3, "_");
            printer.Print("Документ отправлен на печать", 2);

            Console.WriteLine("\n");


            // 8.Пространства имён(Namespaces)
            Console.WriteLine("Задание 8:");

            var hr = new Developer.Employee();
            var developer = new HR.Employee();

            Console.WriteLine(hr.Role);
            Console.WriteLine(developer.Role);

            Console.WriteLine("\n");


            // 9. Структуры (Structs)
            Console.WriteLine("Задание 9:");

            var red = new Color(255, 0, 0);
            var green = new Color(0, 255, 0);
            var blue = new Color(0, 0, 255);

            Console.WriteLine($"Яркость красного - {red.GetBrightness()}, код цвета - {red.ToHexString()}");
            Console.WriteLine($"Яркость зеленого - {green.GetBrightness()}, код цвета - {green.ToHexString()}");
            Console.WriteLine($"Яркость голубого - {blue.GetBrightness()}, код цвета - {blue.ToHexString()}");


            Console.WriteLine("\n");


            // 10. Статики
            Console.WriteLine("Задание 10:");

            var counter1 = new Counter();
            var counter2 = new Counter();
            var counter3 = new Counter();
            var counter4 = new Counter();

            Console.WriteLine(counter4.GetTotalCount());

            Console.WriteLine("\n");


            // 11. Интерфейсы
            Console.WriteLine("Задание 11:");

            var employee = new Employee(5000);
            var freelancer = new Freelancer(30);
            var list1 = new List<IPayable>() { employee, freelancer };

            foreach (var item in list1)
            {
                Console.WriteLine(item.GetPaymentAmount());
            }

            Console.WriteLine("\n");


            // 12. ООП (Наследование и Полиморфизм)
            Console.WriteLine("Задание 12:");

            List<Shape> shapes = new List<Shape>
        {
            new Circle(5),
            new Rectangle(4, 6),
            new Circle(2.5),
            new Rectangle(10, 3)
        };

            foreach (var shape in shapes)
            {
                // Вызов через базовый тип, но работает реализация наследника
                Console.WriteLine(shape.Describe());
            }

            Console.WriteLine("\n");


            // 13. Анонимные типы
            Console.WriteLine("Задание 13:");

            var arr = new[] { "Apple", "Banana", "Cherry" };

            var collection = arr.Select(it => new { Name = it, Length = it.Length, isShort = it.Length < 6 });

            foreach (var item in collection)
            {
                Console.WriteLine($"Название - {item.Name}, Длина - {item.Length}, Длина меньше 6 символов? - {item.isShort}");
            }

            Console.WriteLine("\n");


            // 14. Частичные классы (Partial Classes)
            Console.WriteLine("Задание 14:");

            var user1 = new User() { Id = 1, Name = "Maria", Email = "maria.com" };
            var user2 = new User() { Id = 2, Name = "Olga", Email = "olga@gmail.com" };

            Console.WriteLine(user1.ValidateEmail());
            Console.WriteLine(user2.ValidateEmail());

            Console.WriteLine("\n");


            // 15. Работа с датой и временем
            Console.WriteLine("Задание 15:");

            Console.WriteLine("Введите дату рождения (гггг-мм-дд): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            DateTime today = DateTime.Today;

            // 1. Возраст в годах
            int age = today.Year - birthDate.Year;
            if (birthDate > today.AddYears(-age))
            {
                age--;
            }

            // 2. Дни до следующего дня рождения
            DateTime nextBirthday = new DateTime(today.Year, birthDate.Month, birthDate.Day);

            if (nextBirthday < today)
                nextBirthday = nextBirthday.AddYears(1);

            int daysToBirthday = (nextBirthday - today).Days;

            // 3. День недели рождения
            string dayOfWeek = birthDate.ToString("dddd");

            Console.WriteLine($"\nВаш возраст: {age} лет");
            Console.WriteLine($"Дней до следующего дня рождения: {daysToBirthday}");
            Console.WriteLine($"Вы родились в день недели: {dayOfWeek}");

            Console.WriteLine("\n");


            // 16.Обобщенные типы(Generics)
            Console.WriteLine("Задание 16:");

            var box1 = new Box<int> { Content = 12 };
            box1.SwapContent(new Box<int> { Content = 150 });
            Console.WriteLine(box1.Content);

            var box2 = new Box<string> { Content = "TestBox" };
            box2.SwapContent(new Box<string> { Content = "New Box" });
            Console.WriteLine(box2.Content);

            Console.WriteLine("\n");


            // 17. Коллекции
            Console.WriteLine("Задание 17:");

            var students = new Dictionary<string, List<int>>();
            students.TryAdd("Olga", new List<int>() { 4, 5, 3, 4 });
            students.TryAdd("Marat", new List<int>() { 5, 5, 4, 4 });
            students.TryAdd("Ivan", new List<int>() { 4, 3, 4, 5 });

            Console.WriteLine(students.TryGetValue("Mark", out List<int> scores));

            Console.WriteLine("\n");


            // 18. LINQ
            Console.WriteLine("Задание 18:");

            var products = new List<Product>
            {
                new Product("Апельсин", 40.5, "Фрукт") ,
                new Product("Томат", 160.2, "Овощь") ,
                new Product("Телевизор", 1640.8, "Электроника"),
                new Product("Диван", 2546.5, "Мебель"),
                new Product("Кардиган", 250.1, "Одежда"),
            };

            var filtered1 = products.Where(it => it.Category == "Электроника");
            foreach (var item in filtered1)
            {
                Console.WriteLine(item.Name);
            }

            var filtered2 = products.Where(it => it.Price > 1000);
            foreach (var item in filtered2)
            {
                Console.WriteLine(item.Name);
            }

            var sorted = products.OrderByDescending(it => it.Price);
            foreach (var item in sorted)
            {
                Console.WriteLine(item.Name);
            }

            var names = products.Select(it => it.Name);
            foreach (var it in names)
            {
                Console.WriteLine(it);
            }

            var take = products.Take(3);
            foreach (var item in take)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("\n");
        }

    }

    public static class MathUtils
    {
        public static double Calculate(int a, int b, Operation operation)
        {
            switch (operation)
            {
                case Operation.Sum:
                    return a + b;
                case Operation.Sub:
                    return a - b;
                case Operation.Mul:
                    return a * b;
                case Operation.Div:
                    return a / b;
                default:
                    return 0;
            }
        }
    }

    public enum Operation
    {
        Sum,
        Sub,
        Mul,
        Div,
    }

    public enum TrafficLight
    {
        Red,
        Yellow,
        Green,
    }

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public bool IsAvailable { get; set; }

        public Book(string title, string author, int year, bool isAvailable)
        {
            Title = title;
            Author = author;
            Year = year;
            IsAvailable = isAvailable;
        }

        public void Borrow()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                Console.WriteLine("Книга забронирована");
            }
            else
            {
                Console.WriteLine("Данная книга недоступна");
                throw new ArgumentNullException("Данная книга недоступна");
            }
        }

        public void Return()
        {
            if (!IsAvailable)
            {
                IsAvailable = true;
                Console.WriteLine("Книга возвращена");
            }
        }
    }

    public class Printer
    {
        public void Print(string text)
        {
            Console.WriteLine(text);
        }

        public void Print(string text, int count)
        {
            while (count > 0)
            {
                Console.WriteLine(text);
                count -= 1;
            }
        }

        public void Print(string text, int count, string prefix)
        {
            while (count > 0)
            {
                Console.WriteLine($"{prefix}{text}");
                count -= 1;
            }
        }
    }

    public struct Color
    {
        public byte R, G, B;

        public Color(byte r, byte g, byte b)
        {
            R = r; G = g; B = b;
        }

        public double GetBrightness()
        {
            return (R + G + B) / 3.0;
        }

        public string ToHexString()
        {
            return $"#{R:X2}{G:X2}{B:X2}";
        }
    }

    public class Counter
    {
        static int totalCount { get; set; }

        static Counter()
        {
            totalCount = 0;
            Console.WriteLine("Counter initialized");
        }

        public Counter()
        {
            totalCount += 1;

        }

        public int GetTotalCount()
        {
            return totalCount;
        }
    }

    public class Employee : IPayable
    {
        private decimal MonthPayment { get; set; }

        public Employee(decimal monthPayment)
        {
            MonthPayment = monthPayment;
        }
        public decimal GetPaymentAmount()
        {
            return MonthPayment;
        }
    }

    public class Freelancer : IPayable
    {
        public decimal HourPayment { get; set; }
        public Freelancer(decimal hourPayment)
        {
            HourPayment = hourPayment;
        }
        public decimal GetPaymentAmount()
        {
            return HourPayment * 8 * 21;
        }
    }

    public abstract class Shape
    {
        public abstract double GetArea();


        public virtual string Describe()
        {
            return "Это геометрическая фигура.";
        }
    }

    public class Circle : Shape
    {
        private const double Pi = 3.14;
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }


        public override double GetArea()
        {
            return Pi * Math.Pow(Radius, 2);
        }

        public override string Describe()
        {
            return $"Фигура - круг, площадью - {GetArea():F2}";
        }
    }

    public class Rectangle : Shape
    {
        public int Width { get; }
        public int Height { get; }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }

        public override string Describe()
        {
            return $"Фигура - прямоугольник, площадью - {GetArea():F2}";
        }
    }

    public class Box<T>
    {
        public T Content { get; set; }

        public void SwapContent(Box<T> other)
        {
            Content = other.Content;
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }

        public Product(string name, double price, string category)
        {
            Name = name;
            Price = price;
            Category = category;
        }
    }
}