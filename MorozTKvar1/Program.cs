using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorozTKvar1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1. Набранные баллы: ");
            string task1 = Console.ReadLine();
            Console.WriteLine("Задание 2. Набранные баллы: ");
            string task2 = Console.ReadLine();
            Console.WriteLine("Задание 3. Набранные баллы: ");
            string task3 = Console.ReadLine();
            Console.WriteLine("Задание 4. Набранные баллы: ");
            string task4 = Console.ReadLine();

            Result(task1, task2, task3, task4);
            Console.Read();
        }

        public static bool Result(string task1, string task2, string task3, string task4)
        {
            int t1;
            int t2;
            int t3;
            int t4;
            
            if (int.TryParse(task1, out t1) == false)
            {
                Console.WriteLine("Неверный формат данных в заполнении набранных баллов Задания 1!");
                return false;
            }
            if (t1 > 10 || t1 < 0)
            {
                Console.WriteLine("НЕВЕРНЫЙ ДИАПАЗОН! Максимальное количество баллов за Задание 1 - 10, минмальное - 0.");
                return false;
            }


            if (int.TryParse(task2, out t2) == false)
            {
                Console.WriteLine("Неверный формат данных в заполнении набранных баллов Задания 2!");
                return false;
            }
            if (t2 > 50 || t2 < 0)
            {
                Console.WriteLine("НЕВЕРНЫЙ ДИАПАЗОН! Максимальное количество баллов баллов за Задание 2 - 50, минмальное - 0.");
                return false;
            }


            if (int.TryParse(task3, out t3) == false)
            {
                Console.WriteLine("Неверный формат данных в заполнении набранных баллов Задания 3!");
                return false;
            }
            if (t3 > 30 || t3 < 0)
            {
                Console.WriteLine("НЕВЕРНЫЙ ДИАПАЗОН! Максимальное количество баллов баллов за Задание 3 - 30, минмальное - 0.");
                return false;
            }


            if (int.TryParse(task4, out t4) == false)
            {
                Console.WriteLine("Неверный формат данных в заполнении набранных баллов Задания 4!");
                return false;
            }
            if (t4 > 10 || t4 < 0)
            {
                Console.WriteLine("НЕВЕРНЫЙ ДИАПАЗОН! Максимальное количество баллов баллов за Задание 4 - 10, минмальное - 0.");
                return false;
            }


            int res = t1 + t2 + t3 + t4;
            Console.WriteLine($"Количество баллов: {res}");

            if (res >= 70 && res <= 100)
            {
                Console.WriteLine("Оценка: 5");
            }

            else if (res >= 40 && res <= 69)
            {
                Console.WriteLine("Оценка: 4");
            }

            else if (res >= 20 && res <= 39)
            {
                Console.WriteLine("Оценка: 3");
            }

            else if (res >= 0 && res <= 19)
            {
                Console.WriteLine("Оценка: 2");
            }

            return true;
        }
    }
}
