using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Practice
{
    internal class Example
    {
        static void Main(string[] args)
        {
            // Домашнее задание (уроки 5-6)
            // 1. ТОЧКА НА ПЛОСКОСТИ:
            Console.WriteLine("Задание 1:");

            var struct1 = new Point(12, 13);
            var struct2 = new Point(7, 8);

            Console.WriteLine(struct1.DistanceFromZero());
            Console.WriteLine(struct2.DistanceFromZero());
            Console.WriteLine("\n");


            // 2. ДЕНЬ:
            Console.WriteLine("Задание 2:");

            var struct3 = new DayInfo(3, 11);
            var struct4 = new DayInfo(0, 13);

            Console.WriteLine(struct3.isValid());
            Console.WriteLine(struct4.isValid());
            Console.WriteLine("\n");


            // 3. СЧЕТЧИК ОБЪЕКТОВ:
            Console.WriteLine("Задание 3:");

            var user1 = new User();
            var user2 = new User();
            var user3 = new User();
            var user4 = new User();
            var user5 = new User();


            Console.WriteLine(User.TotalUsers);
            Console.WriteLine("\n");


            // 4. КАЛЬКУЛЯТОР:
            Console.WriteLine("Задание 4:");

            Console.WriteLine(MathHelper.Add(5, 6));
            Console.WriteLine(MathHelper.Subtract(15, 7));
            Console.WriteLine(MathHelper.Multiply(8, 9));
            Console.WriteLine("\n");


            // 5. ХРАНИЛИЩЕ ДАННЫХ:
            Console.WriteLine("Задание 5:");

            IStorage storage1 = new FileStorage();
            IStorage storage2 = new MemoryStorage();

            Console.WriteLine(storage1.Save("документов"));
            Console.WriteLine(storage2.Save("файлов"));
            Console.WriteLine("\n");


            // 6. ИНКАПСУЛЯЦИЯ - СЧЕТЧИК ШАГОВ:
            Console.WriteLine("Задание 6:");

            var counter = new StepCounter();

            counter.AddSteps(5);
            Console.WriteLine(counter.GetSteps());

            counter.AddSteps(2);
            Console.WriteLine(counter.GetSteps());

            counter.Reset();
            Console.WriteLine(counter.GetSteps());

            Console.WriteLine("\n");


            // 7. НАСЛЕДОВАНИЕ - ТРАНСПОРТ:
            Console.WriteLine("Задание 7:");

            Transport transport1 = new Transport(550, "Samalet");
            transport1.Move();

            Transport transport2 = new Car(60, "Honda");
            transport2.Move();

            Transport transport3 = new Bycicle(10, "Rover");
            transport3.Move();

            Console.WriteLine("\n");


            // 8. ПОЛИМОРФИЗМ - ФИГУРЫ:
            Console.WriteLine("Задание 8:");

            Shape shape1 = new Rectangle(2,3);
            Shape shape2 = new Circle(4);

            Console.WriteLine(shape1.GetArea());
            Console.WriteLine(shape2.GetArea());
            Console.WriteLine("\n");
        }

        // 1. ТОЧКА НА ПЛОСКОСТИ:
        public struct Point
        {
            public int X { get; }
            public int Y { get; }

            public Point(int x, int y)
            {
                X = x; Y = y;
            }

            public double DistanceFromZero()
            {
                return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
            }
        }

        // 2. ДЕНЬ:
        public struct DayInfo
        {
            public int Day { get; }
            public int Month { get; }

            public DayInfo(int day, int month)
            {
                Day = day; Month = month;
            }

            public bool isValid()
            {
                return Day > 0 && Day <= 31 && Month > 0 && Month <= 12;
            }
        }

        // 3. СЧЕТЧИК ОБЪЕКТОВ:
        public class User
        {
            public static int TotalUsers { get; set; }

            public User()
            {
                TotalUsers += 1;
            }
        }

        // 4. КАЛЬКУЛЯТОР:
        public static class MathHelper
        {
            public static int Add(int a, int b)
            {
                return a + b;
            }

            public static int Subtract(int a, int b)
            {
                return a - b;
            }

            public static int Multiply(int a, int b)
            {
                return a * b;
            }
        }

        // 5. ХРАНИЛИЩЕ ДАННЫХ:
        interface IStorage
        {
            string Save(string data);
        }

        public class FileStorage : IStorage
        {
            public string Save(string data)
            {
                return $"Данные {data} сохранены в файл";
            }
        }

        public class MemoryStorage : IStorage
        {
            public string Save(string data)
            {
                return $"Данные {data} сохранены в память";
            }
        }

        // 6. ИНКАПСУЛЯЦИЯ - СЧЕТЧИК ШАГОВ:
        public class StepCounter
        {
            private int steps;

            public void AddSteps(int count)
            {
                if (count > 0)
                {
                    steps += count;
                }
            }

            public void Reset()
            {
                steps = 0;
            }

            public int GetSteps()
            {
                return steps;
            }
        }

        // 7. НАСЛЕДОВАНИЕ - ТРАНСПОРТ:
        public class Transport
        {
            public int Speed { get; }
            public string Name { get; }

            public Transport(int speed, string name)
            {
                Speed = speed; Name = name;
            }

            public virtual void Move()
            {
                Console.WriteLine("Транспорт движется");
            }
        }

        public class Car : Transport
        {
            public Car(int speed, string name)
                : base(speed, name)
            {

            }
            public override void Move()
            {
                Console.WriteLine($"Машина едет со скоростью {Speed} км/ч");
            }
        }

        public class Bycicle : Transport
        {
            public Bycicle(int speed, string name)
                : base(speed, name)
            {

            }

            public override void Move()
            {
                Console.WriteLine($"Велосипед едет со скоростью {Speed} км/ч");
            }
        }

        // 8. ПОЛИМОРФИЗМ - ФИГУРЫ:
        public class Shape
        {
            public virtual double GetArea()
            {
                return 0;
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
        }

        public class Circle : Shape
        {
            private const double Pi = 3.14;
            public int Radius { get; }

            public Circle(int radius)
            {
                Radius = radius;
            }


            public override double GetArea()
            {
                return Pi * Math.Pow(Radius, 2);
            }
        }
    }
}