using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLab5_1
{
    class Lab5_1
    {
        static void Main(string[] args)
        {
            int n = 7;
            double[] array = new double[n];
            int t = 1;
            double Sum=0;
            double average;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите {0}-й элемент массива - ", t++);
                array[i] = Convert.ToDouble(Console.ReadLine());
                Sum += array[i];
            }
            average = Sum / n;
            Console.WriteLine("Среднее арифметическое - {0:f4}", average);
            Console.Write("Для завершения нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
