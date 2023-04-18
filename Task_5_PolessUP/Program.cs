using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5_PolessUP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива:");
            int n = int.Parse(Console.ReadLine());

            int[] nums = new int[n];

            Console.WriteLine("Введите элементы массива:");

            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            int max = nums[0];

            int j = 0;

            for (int i = 0; i < n; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                    j = i;
                }
            }

            Console.WriteLine($"Максимальный индекс числа: {j}");

            Console.ReadKey();
        }
    }
}
