using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_inf_input_
{
    class Program
    {
        static void Main(string[] args)
        {
            int input, i = 1, sum = 0, average = 0;
            do
            {
                Console.Write("Введите число, не равное 0: ");
                input =  Convert.ToInt32(Console.ReadLine());
                sum += input;
                i++;
            } while (input != 0);

            average = sum / (i - 2);
            Console.WriteLine($"Общая сумма: {sum}");
            Console.WriteLine($"Кол-во чисел: {i-2}");
            Console.WriteLine($"Среднее: {average}");
            Console.ReadLine();
        }
    }
}