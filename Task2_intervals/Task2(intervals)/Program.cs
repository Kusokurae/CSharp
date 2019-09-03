using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_intervals_
{
    class Program
    {
        static void Main(string[] args)
        {
            int switcher, sum = 0;
            Console.WriteLine("Введите границы интервала: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                switcher = a;
                a = b;
                b = switcher;
            }

            for (; a < b; a++)
            {
                Console.Write("Введите число: ");
                int input = Convert.ToInt32(Console.ReadLine());
                if (input % 2 == 1)
                {
                    sum += input;
                }
            }
            Console.WriteLine($"Сумма нечетных чисел: {sum}");
            Console.ReadLine();
        }
    }
}
