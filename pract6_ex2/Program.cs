using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract6_ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] arr = new int[10];
            int min = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-30, 30);
                Console.WriteLine("[" + i + "]: " + arr[i] + " ");
            }

            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[1] < arr[0])
                    min = arr[1];
                else min = arr[0];
            }
            Console.WriteLine("First minimal number is: " + min);
            Console.ReadKey();
        }
    }
}
