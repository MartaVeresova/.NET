namespace Practice
{
    internal class Lesson1_Lesson2
    {
        static void Main(string[] args)
        {
            // Домашнее задание (уроки 1-2)
            // 1. ПЕРЕМЕННЫЕ:
            Console.WriteLine("Задание 1:");

            string score = "String Value";
            double Score = 128.465;
            object SCORE = 15;

            Console.WriteLine(score);
            Console.WriteLine(Score);
            Console.WriteLine(SCORE);

            //object o = 1;
            //object o1 = "str";
            //int i = 1;
            //double d = 12.4;
            //string s = "2";
            //bool b = false;
            //char c = 'r';


            //Type objType = o.GetType();
            //Type objType1 = o1.GetType();
            //Type intType = i.GetType();
            //Type doubleType = d.GetType();
            //Type strType = s.GetType();
            //Type boolType = b.GetType();
            //Type charType = c.GetType();

            //Console.WriteLine(objType);
            //Console.WriteLine(objType1);
            //Console.WriteLine(intType);
            //Console.WriteLine(doubleType);
            //Console.WriteLine(strType);
            //Console.WriteLine(boolType);
            //Console.WriteLine(charType);
            Console.WriteLine("\n");


            // 2.БАЗОВЫЕ ТИПЫ ДАННЫХ (string, int, bool):
            Console.WriteLine("Задание 2:");

            string name = "Бакштай Виталий";
            int age = 25;
            bool isStudent = true;

            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(isStudent);
            Console.WriteLine("\n");


            // 3.СИМВОЛЫ И УПРАВЛЯЮЩИЕ ПОСЛЕДОВАТЕЛЬНОСТИ:
            Console.WriteLine("Задание 3:");

            Console.WriteLine("Привет\n\tМир!");
            //Console.WriteLine("Марта\tАлександровна\n\n\tВересова");
            Console.WriteLine("\n");


            // 4.ТИПЫ ДАННЫХ И ДИАПАЗОНЫ ЗНАЧЕНИЙ:
            Console.WriteLine("Задание 4:");

            byte byteMax = 255;
            sbyte sbyteMax = 127;
            short shortMax = 32767;
            ushort ushortMax = 65535;
            int intMax = 2147483647;
            uint uintMax = 4294967295;
            long longMax = 9223372036854775807;
            ulong ulongMax = 18446744073709551615;

            Console.WriteLine(byteMax);
            Console.WriteLine(sbyteMax);
            Console.WriteLine(shortMax);
            Console.WriteLine(ushortMax);
            Console.WriteLine(intMax);
            Console.WriteLine(uintMax);
            Console.WriteLine(longMax);
            Console.WriteLine(ulongMax);

            //byte byteMin = 0;
            //sbyte sbyteMin = -128;
            //short shortMin = -32768;
            //ushort ushortMin = 0;
            //int intMin = -2147483648;
            //uint uintMin = 0;
            //long longMin = -9223372036854775808;
            //ulong ulongMin = 0;

            //Console.WriteLine(byteMin);
            //Console.WriteLine(sbyteMin);
            //Console.WriteLine(shortMin);
            //Console.WriteLine(ushortMin);
            //Console.WriteLine(intMin);
            //Console.WriteLine(uintMin);
            //Console.WriteLine(longMin);
            //Console.WriteLine(ulongMin);
            Console.WriteLine("\n");


            // 5. НЕЯВНАЯ ТИПИЗАЦИЯ (var):
            var strVal = "C#";
            var numVal = 2026;
            var charVal = '!';


            // 6. ПРЕОБРАЗОВАНИЕ ВВОДА (Convert):
            Console.WriteLine("Задание 6:");

            Console.WriteLine("Введите возраст:");
            int ageConv = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите вес:");
            double weightConv = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите размер зарплаты:");
            decimal salaryConv = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("\n");


            // 7. ЯВНОЕ И НЕЯВНОЕ ПРЕОБРАЗОВАНИЕ ТИПОВ:
            Console.WriteLine("Задание 7:");

            int a = 300;
            byte b1 = (byte)a;
            Console.WriteLine(b1); // будет 44 - из-за переполнения пошел по кругу

            try
            {
                byte b2 = checked((byte)a); //механизм, к-ый контролирует переполнение
                Console.WriteLine(b2);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("\n");


            // 8. УПАКОВКА И РАСПАКОВКА (boxing/unboxing)
            Console.WriteLine("Задание 8:");

            int int3 = 42;
            object obj3 = int3;

            obj3 = 21;
            int3 = (int)obj3;
            Console.WriteLine(int3); //21 - т.к. распаковывается из object уже измененное значение
            Console.WriteLine(obj3); //21

            Console.WriteLine("\n");


            // 9. ПРЕОБРАЗОВАНИЕ ЧЕРЕЗ Parse:
            Console.WriteLine("Задание 9:");

            string strI = "123";
            Console.WriteLine(int.Parse(strI));
            string strD = "86,1";
            Console.WriteLine(double.Parse(strD));
            Console.WriteLine("\n");


            // 10. ПРОВЕРКА ТИПА (is,as):
            Console.WriteLine("Задание 10:");

            //Оператор is
            object obj6 = "Hello";
            if (obj6 is string)
            {
                Console.WriteLine(obj6);
            }

            //Оператор as
            object obj7 = "Привет мир!";
            string str7 = obj7 as string;
            if (str7 != null)
            {
                Console.WriteLine(str7);
            }
            else
            {
                Console.WriteLine("Приведение типа не удалось");
            }

            //Оператор as
            object obj8 = 123;
            string str8 = obj8 as string;
            if (str8 == null)
            {
                Console.WriteLine("obj8 не является строкой");
            }
            Console.WriteLine("\n");


            // 11. УСЛОВНЫЕ КОНСТРУКЦИИ (if-else):
            Console.WriteLine("Задание 11:");

            int num7 = 7;
            int num9 = 9;

            if (num7 > num9)
            {
                Console.WriteLine($"Число {num7} больше, чем число {num9}");
            }
            else if (num7 < num9)
            {
                Console.WriteLine($"Число {num7} меньше, чем число {num9}");
            }
            else
            {
                Console.WriteLine($"Числа {num7} и {num9} равны");
            }
            Console.WriteLine("\n");


            // 12. ТЕРНАРНЫЙ ОПЕРАТОР:
            Console.WriteLine("Задание 12:");

            int num4 = -654;

            Console.WriteLine(num4 > 0 ? "Положительное" : "Отрицательное");
            Console.WriteLine("\n");


            // 13. КОНСТРУКЦИЯ switch:
            Console.WriteLine("Задание 13:");

            int val = 4;

            switch (val)
            {
                case 5:
                    Console.WriteLine("Отлично");
                    break;

                case 4:
                    Console.WriteLine("Хорошо");
                    break;

                case 3:
                    Console.WriteLine("Удовлетворительно");
                    break;

                case 2:
                case 1:
                    Console.WriteLine("Неудовлетворительно");
                    break;

                default:
                    Console.WriteLine("Неверная оценка");
                    break;
            }
            Console.WriteLine("\n");


            // 14. ЦИКЛ for:
            Console.WriteLine("Задание 14:");

            int sum = 0;
            for (int i = 1; i <= 99; i += 2)
            {
                sum += i;
            }
            //for (int i = 1; i <= 99; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        sum += i;
            //    }
            //}
            Console.WriteLine(sum);
            Console.WriteLine("\n");


            // 15. ОБЪЯВЛЕНИЕ И ИНИЦИАЛИЗАЦИЯ ОДНОМЕРНОГО МАССИВА:
            Console.WriteLine("Задание 15:");

            double[] arr1 = { 12.3, 45.7, 56.8, 95.4, 19.6 };
            Console.WriteLine($"Длина - {arr1.Length}. 3-ий элемент - {arr1[2]}");
            Console.WriteLine("\n");


            // 16. ПЕРЕБОР МАССИВА С ПОМОЩЬЮ foreach:
            Console.WriteLine("Задание 16:");

            string[] arr2 = { "apple", "BANANA", "Cherry" };
            foreach (var item in arr2)
            {
                Console.WriteLine(item.ToLower());
            }
        }
    }
}