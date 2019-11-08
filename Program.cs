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
        static int swap(int a)
        {
            string b = Convert.ToString(a);
            string d = " ";
            for (int i = 0; i < b.Length; i++)
            {
                d += b[b.Length - 1 - i];
            }

            a = Convert.ToInt32(d);
            return a;
        }
        static void Main(string[] args)
        {
            int a = 0;
            Console.WriteLine("Пиши число");
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Хан Узбек");
            }
            a = swap(a);
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
