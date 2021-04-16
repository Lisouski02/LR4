using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {

        static void Main(string[] args)
        {

            int n;
            Console.Write("Введите колличество элементов в массиве : ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[n];


            Random r = new Random();

            for (int i = 0; i < n; i++)
            {
                mas[i] = r.Next(-100, 100);
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine();
            int index = Array.FindIndex(mas, g);
            Console.WriteLine(index);
            int sum = 0;
            for (; index < n; index++)
            {
                sum += Math.Abs(mas[index]);

            }
            Console.WriteLine("Сумма всех элементов после отрицательного в модуле = " + sum);

        }

        static bool g(int n)
        {
            return n < 0;
        }
    }
}
