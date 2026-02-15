using System.Collections.Generic;
using System.Drawing;

namespace Practice
{
    internal class Example
    {
        static void Main(string[] args)
        {
            // Домашнее задание (уроки 7-8)
            // 1. DATETIME:
            Console.WriteLine("Задание 1:");

            var person = new Person("Marta", new DateTime(1990, 03, 28));
            Console.WriteLine(person.GetAge());
            Console.WriteLine("\n");

            // 2. TimeSpan:
            Console.WriteLine("Задание 2:");

            var workSession = new WorkSession(new DateTime(2026, 02, 12, 23, 30, 00), new DateTime(2026, 02, 15, 12, 15, 00));
            Console.WriteLine(workSession.GetTime());
            Console.WriteLine(workSession.GetMinutes());

            Console.WriteLine("\n");

            // 3. List:
            Console.WriteLine("Задание 3:");

            var students = new List<Student>();
            students.AddRange([
                new Student(Guid.NewGuid(), "Max", 5),
                new Student(Guid.NewGuid(), "Oleg", 3),
                new Student(Guid.NewGuid(), "Alisa", 4),
                new Student(Guid.NewGuid(), "Harry", 2),
                new Student(Guid.NewGuid(), "Jane", 4),
            ]);

            students.ForEach(st =>
            {
                if (st.GetExcellentStudent() != null)
                {
                    Console.WriteLine(st.Name);
                }
            });

            Console.WriteLine("\n");

            // 4. Dictionary:
            Console.WriteLine("Задание 4:");

            var books = new Dictionary<int, Book>();
            books.TryAdd(3, new Book(3, "10 негритят", "Агата Кристи"));
            books.TryAdd(6, new Book(6, "Маленький принц", "Антуан де Сент-Экзюпери"));
            books.TryAdd(9, new Book(9, "Мизери", "Стивен Кинг"));


            Console.Write("Введите айди книги: ");
            int id = Convert.ToInt32(Console.ReadLine());

            if (books.TryGetValue(id, out Book book))
            {
                Console.WriteLine(book.Title);
            }
            else
            {
                Console.WriteLine("Такой книги не существует в нашей библиотЭке!");
            }

            Console.WriteLine("\n");

            // 5. Dictionary + List:
            Console.WriteLine("Задание 5:");

            var dep1 = new Department(1, "Отдел разработки");
            var dep2 = new Department(2, "Отдел тестирования");
            var dep3 = new Department(3, "Отдел маркетинга");

            var emp1 = new Employee(100, "Иванов");
            var emp2 = new Employee(101, "Петров");
            var emp3 = new Employee(102, "Сидоров");
            var emp4 = new Employee(103, "Красков");
            var emp5 = new Employee(104, "Пинчук");
            var emp6 = new Employee(105, "Мороз");
            var emp7 = new Employee(106, "Галиев");
            var emp8 = new Employee(107, "Усов");
            var emp9 = new Employee(108, "Бориков");


            var employees = new Dictionary<int, List<Employee>>();

            employees.TryAdd(dep1.Id, new List<Employee>() { emp1, emp2, emp3 });
            employees.TryAdd(dep2.Id, new List<Employee>() { emp4, emp5, emp6 });
            employees.TryAdd(dep3.Id, new List<Employee>() { emp7, emp8, emp9 });

            Console.Write("Введите айди отдела: ");
            int depId = Convert.ToInt32(Console.ReadLine());

            if (employees.TryGetValue(depId, out List<Employee> emp))
            {
                foreach (var item in emp)
                {
                    Console.WriteLine(item.Name);
                }
            }
            else
            {
                Console.WriteLine("Таких не маем");
            }

            Console.WriteLine("\n");
        }
    }

    // 1. DATETIME:
    public class Person
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        public Person(string name, DateTime birthDate)
        {
            Name = name;
            BirthDate = birthDate;
        }

        public int GetAge()
        {
            var ms = DateTime.Today - BirthDate;

            return (int)ms.TotalDays / 365;

        }
    }

    // 2. TimeSpan:
    public class WorkSession
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }


        public WorkSession(DateTime startTime, DateTime endTime)
        {
            StartTime = startTime;
            EndTime = endTime;
        }

        public double GetTime()
        {
            return (EndTime - StartTime).TotalMicroseconds;
        }

        public string GetMinutes()
        {
            var duration = EndTime - StartTime;

            return $"{(int)duration.TotalHours} часа и {duration.Minutes} минут";
        }
    }

    // 3. List:
    public class Student
    {
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public int Grade { get; set; }


        public Student(Guid guid, string name, int grade)
        {
            Guid = guid;
            Name = name;
            Grade = grade;
        }

        public string? GetExcellentStudent()
        {
            return Grade >= 4 ? Name : null;
        }
    }

    // 4. Dictionary:
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }


        public Book(int id, string title, string author)
        {
            Id = id;
            Title = title;
            Author = author;
        }
    }


    // 5. Dictionary + List:
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}