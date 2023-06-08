using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteElement
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] array = { 1, 3, 4, 6, 8, 3, 6 };

            Console.WriteLine("Nhap so can xoa: ");
            int value = int.Parse(Console.ReadLine());

            int count = 0; // Số phần tử bị xóa

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    count++;
                }
                else
                {
                    array[i - count] = array[i];
                }
            }

            Array.Resize(ref array, array.Length - count);

            foreach (int i in array)
            {
                Console.Write(i + " ");
            }

            Console.ReadKey();
        }
    }
}
