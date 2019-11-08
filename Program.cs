using System;
using System;
using System.Collections.Generic;

namespace True_Bareboha
{
    class Program
    {
        static List<int> vpihni(List<int> Vasyan, int a)
            {
                Random rand = new Random();
                int b = rand.Next(0, 101);
                Vasyan.Add(b);
                if (b == a)
                {
                    return Vasyan;
                }
                return vpihni(Vasyan, a);
            }
        static void position(List<int> Kostyan)
            {
                for ( int i = 0; i < 5; i++)
                {                    
                    Console.Write(Kostyan[i] + " ");
                }
            }
        static void Main(string[] args)
        {
            int a = 0; // Введенное число
            List<int> Vasyan = new List<int>(); // Список всех сгенерированных чисел
            List<int> Kostyan = new List<int>(); // Список позиций числа a
            Console.WriteLine("Пиши рандомное число от 1 до 100");
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
                if ( a < 0 || a > 100)
                {
                    Console.WriteLine("Govna poesh, teper' a = 88");
                    a = 88;
                }
            }
            catch
            {
                Console.WriteLine("Хан Узбек");
            }
            for (int i = 0; i < 5; i++)
            {
                Vasyan = vpihni(Vasyan, a);
                Kostyan.Add(Vasyan.Count);
            }
            Console.WriteLine("Чисел сгенерированно: " + Vasyan.Count);
            Console.WriteLine("Позиции числа " + a + ":");
            position(Kostyan);
            Console.ReadKey();
        }
    }
}
