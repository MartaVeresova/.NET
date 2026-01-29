using System.Text.RegularExpressions;

namespace Practice
{
    internal class Lesson3_Lesson4
    {
        static void Main(string[] args)
        {
            // Домашнее задание (уроки 3-4)
            // 1.1. ПОДСЧЁТ ГЛАСНЫХ:
            Console.WriteLine("Задание 1.1:");

            int CountVowels(string text)
            {
                var vowels = "аеёиоуыэюя";
                int count = 0;

                foreach (var item in text.ToLower())
                {
                    if (vowels.Contains(item))
                    {
                        count++;
                    }
                }

                return count;
            }

            Console.WriteLine(CountVowels("Марта живёт в Минске, а Алина живёт в Бресте"));
            Console.WriteLine("\n");


            // 1.2. ПЕРЕВОРОТ СЛОВ:
            Console.WriteLine("Задание 1.2:");

            string ReverseWords(string text)
            {
                var arr = text.Split(' ');
                var reverse = arr.Reverse();

                return string.Join(' ', reverse);
            }

            Console.WriteLine(ReverseWords("Марта любит сладкое"));
            Console.WriteLine("\n");


            // 2.1. КАЛЬКУЛЯТОР ПЛОЩАДЕЙ:
            Console.WriteLine("Задание 2.1:");

            var geometry = new GeometryHelper();
            var circleArea = geometry.CircleArea(5.6);
            var rectangArea = geometry.RectangArea(1.2, 3.4);

            Console.WriteLine(circleArea);
            Console.WriteLine(rectangArea);
            Console.WriteLine("\n");


            // 2.2. ВАЛИДАЦИЯ ПАРОЛЯ:
            Console.WriteLine("Задание 2.2:");

            bool IsValidPassword(string password)
            {
                // Регулярное выражение \d соответствует любой цифре [0-9]
                bool hasDigit = Regex.IsMatch(password, @"\d");

                // Регулярное выражение \d соответствует заглавной букве
                bool hasUpper = Regex.IsMatch(password, "[A-ZА-ЯЁ]");

                return password.Length >= 8 && hasDigit && hasUpper;
            }

            Console.WriteLine(IsValidPassword("123Abc456Def")); //true
            Console.WriteLine(IsValidPassword("hghghfj")); //false
            Console.WriteLine("\n");


            // 2.3. ГЕНЕРАТОР ПРИВЕТСТВИЯ:
            Console.WriteLine("Задание 2.3:");

            string Greet(string name, int hour)
            {
                if (hour >= 0 && hour <= 5)
                {
                    return $"Доброй ночи, {name}";
                }

                if (hour >= 6 && hour <= 11)
                {
                    return $"Доброе утро, {name}";
                }

                if (hour >= 12 && hour <= 17)
                {
                    return $"Добрый день, {name}";
                }

                if (hour >= 18 && hour <= 23)
                {
                    return $"Добрый вечер, {name}";
                }

                return "Некорректное время";
            }

            Console.WriteLine(Greet("Марина", 3));
            Console.WriteLine(Greet("Олег", 14));
            Console.WriteLine(Greet("Катя", 54));
            Console.WriteLine("\n");


            // 3.1. ДНИ НЕДЕЛИ:
            Console.WriteLine("Задание 3.1:");

            bool isWeekend(Day day)
            {
                return (int)day >= 5;
            }

            Console.WriteLine(isWeekend(Day.Saturday)); //true
            Console.WriteLine(isWeekend(Day.Wednesday)); //false
            Console.WriteLine("\n");


            // 3.2. ДНИ НЕДЕЛИ:
            Console.WriteLine("Задание 3.2:");

            bool IsPassed(Grade grade)
            {
                return ((int)grade >= 3);
            }

            Console.WriteLine(IsPassed(Grade.A)); //true
            Console.WriteLine(IsPassed(Grade.F)); //false
            Console.WriteLine("\n");


            // 3.3. НАПРАВЛЕНИЕ ДВИЖЕНИЯ:
            Console.WriteLine("Задание 3.3:");

            Direction DirectionOpposite(Direction direction)
            {
                var value = (int)direction * (-1);

                return (Direction)value;
            }

            Console.WriteLine(DirectionOpposite(Direction.NORTH));
            Console.WriteLine(DirectionOpposite(Direction.WEST));
            Console.WriteLine("\n");


            // 4.1. КНИГА:
            Console.WriteLine("Задание 4.1:");

            var book = new Book("Ядро и IPS", "Л.Н. Лазарев", 1869, 214);

            Console.WriteLine(book.GetInfo());
            Console.WriteLine("\n");


            // 4.2. СТУДЕНТ:
            Console.WriteLine("Задание 4.2:");

            var student1 = new Student("Alex", "C154", 4.8);
            var student2 = new Student("Oleg", "C157", 3.7);

            Console.WriteLine(student1.IsExcellent());
            Console.WriteLine(student2.IsExcellent());
            Console.WriteLine("\n");


            // 4.3. ПРЯМОУГОЛЬНИК:
            Console.WriteLine("Задание 4.3:");

            var rectangle1 = new Rectangle(4, 3);
            var rectangle2 = new Rectangle(5, 5);

            Console.WriteLine($"Площадь - {rectangle1.GetArea()}, Периметр - {rectangle1.GetPerimeter()}, квадрат? - {rectangle1.IsSquare()}");
            Console.WriteLine($"Площадь - {rectangle2.GetArea()}, Периметр - {rectangle2.GetPerimeter()}, квадрат? - {rectangle2.IsSquare()}");
            Console.WriteLine("\n");


            // 5.1. КАЛЬКУЛЯТОР:
            Console.WriteLine("Задание 5.1:");

            var calculator = new Calculator();

            Console.WriteLine(calculator.Multiply(2, 3));
            Console.WriteLine(calculator.Multiply(2.5, 6.7));
            Console.WriteLine(calculator.Multiply(4, 5, 6));

            Console.WriteLine("\n");
        }
    }

    enum Day
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday,
    }

    enum Grade
    {
        F = 1,
        D,
        C,
        B,
        A,
    }

    enum Direction
    {
        NORTH = -1, //север
        SOUTH = 1, //юг
        WEST = -2,//запад
        EAST = 2, //восток
    }


    // 2.1. КАЛЬКУЛЯТОР ПЛОЩАДЕЙ:
    public class GeometryHelper
    {

        public double CircleArea(double radius)
        {
            return 3.14 * Math.Pow(radius, 2);
        }

        public double RectangArea(double a, double b)
        {
            return a * b;
        }
    }


    // 4.1. КНИГА:
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public int Pages { get; set; }

        public Book(string title, string author, int year, int pages)
        {
            Title = title;
            Author = author;
            Year = year;
            Pages = pages;
        }

        public string GetInfo()
        {
            return $"{Title} ({Author}, {Year}), {Pages}стр.";
        }
    }


    // 4.2. СТУДЕНТ:
    public class Student
    {
        private string Name { get; set; }
        private string Group { get; set; }
        private double Gpa { get; set; }

        public Student(string name, string group, double gpa)
        {
            Name = name;
            Group = group;
            Gpa = gpa;
        }

        public bool IsExcellent()
        {
            return Gpa >= 4.5;
        }
    }


    // 4.3. ПРЯМОУГОЛЬНИК:
    public class Rectangle
    {
        private int Width { get; set; }
        private int Height { get; set; }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int GetArea()
        {
            return Width * Height;
        }
        public int GetPerimeter()
        {
            return (Width + Height) * 2;
        }
        public bool IsSquare()
        {
            return Width == Height;
        }
    }


    // 5.1. КАЛЬКУЛЯТОР:
    public class Calculator
    {

        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public double Multiply(double a, double b)
        {
            return a + b;
        }
        public int Multiply(int a, int b, int c)
        {
            return a * b * c;
        }
    }
}