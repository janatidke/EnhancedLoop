using System;

namespace EnhancedLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Print the element of  array:");

            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7 };


            foreach (int items in array)
            {
                Console.WriteLine(items);
            }
        }
    }
}
