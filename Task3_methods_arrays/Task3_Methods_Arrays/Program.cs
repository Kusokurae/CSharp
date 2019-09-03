using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static Random gen = new Random();
        static void Main(string[] args)
        {
            Console.Write("Введите номер задания (1-18): ");
            string num = Console.ReadLine();

            int[] array;
            switch (num)
            {
                case "1":
                    Gen_array(out array);
                    Task1(array);
                    break;
                case "2":
                    Gen_array(out array);
                    Task2(array);
                    break;
                case "3":
                    Console.WriteLine("Еще выполняется ;)");
                    //Gen_array(out array);
                    //Task3(array);
                    break;
                case "4":
                    Gen_array(out array);
                    Task4(array);
                    break;
                case "5":
                    Console.WriteLine("Еще выполняется ;)");
                    break;
                case "6":
                    Gen_array(out array);
                    Task6(array);
                    break;
                case "7":
                    Gen_array(out array);
                    Task7(array);
                    break;
                case "8":
                    Console.WriteLine("Еще выполняется ;)");
                    break;
                case "9":
                    Console.WriteLine("Еще выполняется ;)");
                    break;
                case "10":
                    Task10();
                    break;
                case "11":
                    Console.WriteLine("Еще выполняется ;)");
                    break;
                case "12":
                    Console.WriteLine("Еще выполняется ;)");
                    break;
                case "13":
                    Task13();
                    break;
                case "14":
                    Task14();
                    break;
                case "15":
                    Task15();
                    break;
                case "16":
                    Console.WriteLine("Еще выполняется ;)");
                    break;
                case "17":
                    Console.WriteLine("Еще выполняется ;)");
                    break;
                case "18":
                    Task18();
                    break;
                default:
                    Console.WriteLine("Введен не номер!");
                    break;
            }
                    Console.ReadKey();
        }

            // Генератор массива
        static void Gen_array(out int[] arr)
            {
                int size;
                Console.Write("Введите размер массива: ");
                string input = Console.ReadLine();

                while (!int.TryParse(input, out size))
                {
                    Console.WriteLine("Введено не число!");
                    Console.Write("Введите размер массива: ");
                    input = Console.ReadLine();
                }

                arr = new int[size];

                Console.WriteLine("Сгенерировать массив, ввести вручную или взять палиндром ?(1/2/3)");
                string ans = Console.ReadLine();
                switch (ans)
                {
                    case "1":
                        Console.Write("Исходный массив: ");
                        for (int i = 0; i < arr.Length; i++)
                        {
                            arr[i] = gen.Next(0, 11);
                            Console.Write(arr[i] + " ");
                        }
                        Console.WriteLine();
                        break;
                    case "2":
                        Console.Write("Исходный массив: ");
                        for (int i = 0; i < arr.Length; i++)
                        {
                            arr[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine();
                        break;
                    case "3":
                        Console.Write("Исходный массив: ");
                        for (int i = 0; i < arr.Length; i++)
                        {
                            arr[i] = arr.Length / 2 - i;
                            arr[arr.Length - 1 - i] = arr[i];
                            Console.Write(arr[i] + " ");
                        }
                        Console.WriteLine();
                        break;
                }
            }
            // Вывод в обратном порядке
        static void Task1(int[] arr)
            {
                Console.Write("Массив в обратном порядке: ");
                int temp;
                for (int i = 0; i < arr.Length / 2; i++)
                {
                    temp = arr[i];
                    arr[i] = arr[arr.Length - 1 - i];
                    arr[arr.Length - 1 - i] = temp;
                }

                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine();
            }
            // Среднее между макс. и мин.
        static void Task2(int[] arr)
        {
            int max = arr[0];
            int min = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                else if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("Cреднее арифметическое между мин. и макс. элементами: " + (max+min)/2 );
        }
            // Сдвиг массива вправо(incomp)
        static void Task3(int[] arr)
        {
            Console.Write("Ввыедите величину сдвига: ");
            int move = Int32.Parse(Console.ReadLine());

            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i + move < arr.Length)
                {
                    temp = arr[i];
                    arr[i] = arr[i + move];
                    arr[i + move] = temp;
                }
                else if (i+move >= arr.Length - 1)
                {
                    temp = arr[(arr.Length - 1) - i + move];
                    arr[(arr.Length - 1) - i + move] = arr[i];
                    arr[i] = temp;
                }
                Console.Write(arr[i] + " ");
            }
        }
            // Проверка на палиндром
        static void Task4(int[] arr)
            {
                for (int i = 0; i < arr.Length / 2; i++)
                {
                    if (arr[i] != arr[arr.Length - i - 1])
                    {
                        Console.WriteLine("Массив не палиндром");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Массив - палиндром");
                        break;
                    }
                }
            }
            // Проверка на дубли
        static void Task6(int[] arr)
        {
            int a = -1;
            int temp = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                temp = arr[i];
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] == temp)
                    {
                        Console.WriteLine("Есть дубли, номера " + i + " и " + j);
                        a = 1;
                        break;
                    }
                }
            }
            if (a == -1)
            {
                Console.WriteLine("Нет дублей");
            }
        }
        // Вывод до первого 0
        static void Task7(int[] arr)
        {
            Console.WriteLine("Жду первый 0...");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    Console.Write(arr[i] + " ");
                    arr[i]--;
                    if (i == arr.Length - 1)
                    {
                        i = 0;
                        Console.WriteLine();
                        continue;
                    }
                }
                else
                {
                    Console.Write(arr[i] + " ");
                    break;
                }
            }
        }
            // Максимумы в строках
        static void Task10()
        {
            int[,] matrix;

            int size = 0;
            Console.Write("Введите размерность матрицы: ");
            size = Convert.ToInt32(Console.ReadLine());

            matrix = new int[size, size];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = gen.Next(1, 10);
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }

            int max;
            int[] maxarr = new int[size];
            Console.Write("Максимумы в строках: ");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                max = matrix[i, 0];
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                    }
                }
                maxarr[i] = max;
                
            }

            
            int min = maxarr[0];
            for (int i = 0; i < maxarr.Length; i++)
            {
                Console.Write(maxarr[i] + " ");
                if (maxarr[i] < min)
                {
                    min = maxarr[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("Минимум среди максимумов: " + min);
        }
            // Удаление креста
        static void Task13()
        {
            int[,] matrix;

            int i, j, size = 0;
            while (size < 4)
            {
                Console.Write("Введите размерность матрицы: ");
                size = Convert.ToInt32(Console.ReadLine());
            }
            matrix = new int[size, size];
            for (i = 0; i < matrix.GetLength(0); i++)
            {
                for (j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = gen.Next(1, 10);
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            
            Console.WriteLine("Введите координаты удаляемого пересечения");
            Console.WriteLine("Row = ");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Column = ");
            int column = int.Parse(Console.ReadLine());
            Console.WriteLine("Новая матрица:");

            for (i = 0; i < matrix.GetLength(0); i++)
            {
                if (i != row - 1)
                {
                    for (j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (j != column - 1)
                        {
                            Console.Write(matrix[i, j] + " ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
            // Вычисление определителя
        static void Task14()
            {
                int[,] matrix;

                int size = 0;
                Console.Write("Введите размерность матрицы: ");
                size = Convert.ToInt32(Console.ReadLine());

                matrix = new int[size, size];

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = gen.Next(1, 10);
                    }
                }

                // Печать массива
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    Console.WriteLine();
                }

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    // matrix[0, i] * |minor(matrix[0, i])|
                    GetMinor(matrix, 0, 1);
                }

                int det = GetDet(matrix);
                Console.WriteLine("Определитель матрицы: " + det);
            }
        // Факториал
        static void Task15()
        {
            int Factor = 0;
            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number != 0)
            {
                Factor = number * Fact(number-1);
            }
            Console.WriteLine("{0}! = {1}",number,Factor);
        }
            // Фибоначчи
        static void Task18()
        {
            Console.Write("Введите кол-во чисел Фиббоначчи: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Последовательность Фиббоначчи: ");
            int[] Fibb = {0, 1, 1};
            for (int i = 0; i < num; i++)
            {
                Console.Write(Fibb[0] + " ");
                Fibb[2] = Fibb[0] + Fibb[1];
                Fibb[0] = Fibb[1];
                Fibb[1] = Fibb[2];
            }
        }

        static int[,] GetMinor(int[,] matrix, int x, int y)
            {
                int[,] minor = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
                int a = 0, b = 0; // счетчики для минора

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (i == x)
                        continue;
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (j == y)
                            continue;
                        minor[a, b] = matrix[i, j];
                        b++;
                    }
                    a++;
                    b = 0;
                }
                return minor;
            }

        static int GetDet(int[,] matrix)
            {
                if (matrix.GetLength(0) == 2)
                {
                    return matrix[0, 0] * matrix[1, 1] - matrix[1, 0] * matrix[0, 1];
                }

                int det = 0;
                int sign = 1;

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    sign = (i % 2 == 0) ? 1 : -1;
                    det += sign * matrix[0, i] * GetDet(GetMinor(matrix, 0, i));
                }

                return det;
            }

        static int Fact(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            int res = num*Fact(num - 1);
            return res;
        }
        }
    }
