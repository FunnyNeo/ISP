using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = 10;
            int[] array = new int[lenght];

            for (int i = 0; i < lenght; i++)
            {
                array[i] = i;
            }

            for (int i = 0; i < lenght; i++)
            {
                Console.WriteLine("Элемент массива "+i+" равен " + array[i]);
                Console.ReadKey();
            }
        }
    }
}
