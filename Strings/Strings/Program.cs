using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            String text = "В, классе String перегружаются два следующих оператора == и != . Оператор == служит для проверки двух символьных строк на равенство. Когда оператор плеснуть == применяется к ссылкам на объекты, он обычно проверяет, делаются ли обе ссылки на один и тот же объект. А когда оператор == применяется к ссылкам на объекты типа String, то на предмет равенства сравнивается содержимое самих строк.";
            Console.WriteLine(text);

            Console.Write("\nГлаголы: ");
            char[] delimitor = new[] { ' ', ',', '.', ';', ':' };
            Searcher(ref text, Parser(text, delimitor), out int count, delimitor);
            //Console.WriteLine("\nНайдено {0} глаголов\n\n", count);

            Console.ReadKey();
        }

        static string[] Parser(string toParse, char[] delim)
        {
            String[] parsed = toParse.Split(delim);
            return parsed;
        }

        static string[] Searcher(ref string text, string[] findFrom, out int count, char[] delim) // Поиск глаголов
        {
            int i = 0;
            count = 0;
            String[] verbs = new String[1];

            string[] ends = new[] { "ить", "ать", "уть", "еть", "оть", "ыть", "ять", "иться", "аться", "уться", "еться", "оться", "ыться", "яться", "ет", "ется", "ют", "ются", "ут", "утся" };
            foreach (string toFind in findFrom)
            {
                foreach (string end in ends)
                {
                    if (toFind.EndsWith(end))
                    {
                        verbs[i] = toFind;
                        Array.Resize(ref verbs, verbs.Length + 1);
                        Console.Write(verbs[i] + ' ');
                        i++;
                        count++;
                    }
                }
            }
            DuckAndResize(ref text, verbs, delim);
            return verbs;
        }

        static void DuckAndResize(ref string changeFrom, string[] verbs, char[] delim)
        {
            for (int j = 0; j < verbs.Length - 1; j++)
            {
                changeFrom = changeFrom.Replace(verbs[j], "Уточка");
            }

            string[] s = changeFrom.Split(' ');
            string swap;
            for (int i = 0; i < s.Length; i++)
            {
                swap = s[i].Trim(delim);
                if ((swap.Length < 5) && (swap.Length > 0) && (swap != "Уточка"))
                {
                    // Console.WriteLine(s[i]);
                    //changeFrom = changeFrom.Replace(swap, "Селезнь");
                    //Console.WriteLine("\n\n" + changeFrom);
                    s[i] = "Селезень";
                }
            }
            changeFrom = string.Join(" ", s);
            Console.WriteLine("\n\n" + changeFrom);
        }
    }
}
