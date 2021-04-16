using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static int[] BubbleSort(int[] mas)
        {
            int hold;
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        hold = mas[i];
                        mas[i] = mas[j];
                        mas[j] = hold;

                    }
                }
            }
            return mas;
        }
        static void Main(string[] args)
        {
            int n;
            Console.Write("Введите колличество элементов в массиве : ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[n];

            Random r = new Random();

            for (int i = 0; i < n; i++)
            {
                mas[i] = r.Next(0, 100);
                Console.Write(mas[i] + " ");
            }

            Console.WriteLine();

            BubbleSort(mas);

            Console.WriteLine("После соритровки:");

            for (int i = 0; i < n; i++)
            {
                Console.Write(mas[i] + " ");
            }

            Console.WriteLine();

            int max, min;

            if (mas[0] * mas[1] < mas[n - 2] * mas[n - 1])
            {
                min = mas[0] * mas[1];
                max = mas[n - 2] * mas[n - 1];
                Console.WriteLine("Минимальное произведение 2-х элементов = " + min);
                Console.WriteLine("Максимальное произведение 2-х элементов = " + max);
            }
        }
    }
}
