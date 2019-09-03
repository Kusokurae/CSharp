using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace FFBE_MK_toget_list
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter needed items:");

            string item = "";
            int sum = 0;
            Regex price_check = new Regex(@"\d+");

            for (int i = 0; ; i++)
            {
                Console.Write(i + 1 + ") ");

                item = Console.ReadLine();

                if (item == "end")
                {
                    Console.WriteLine("You need " + sum + " whatever currency is used atm");
                    Console.WriteLine();
                    break;
                }

                if (price_check.IsMatch(item))
                {
                    Match temp = price_check.Match(item);
                    sum += Convert.ToInt32(temp.Value);
                }
                else
                {
                    Console.WriteLine("Enter correct price");
                    i--;
                }
            }
            Console.ReadKey();
        }
    }
}
// todo: add export to file!!!