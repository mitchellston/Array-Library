using System;
using Array_Library;

namespace ShowCase
{
    class Program
    {
        static void Main()
        {
            double[] double_test = { 5.4, 9.6, 135.6 };
            //adds a value to the array
            double_test = arrayLibrary.add(double_test, 2.5235);
            Console.WriteLine("add value");
            for (int i = 0; i < double_test.Length; i++)
            {
                Console.WriteLine(double_test[i]);
            }
            //this will remove the index 0 from the array (in this case 5.4)
            double_test = arrayLibrary.remove(double_test, 0);
            Console.WriteLine("remove value");
            for (int i = 0; i < double_test.Length; i++)
            {
                Console.WriteLine(double_test[i]);
            }
            //this will swap index 1 and two which means that they change from position to the others position
            int[] int_swapIndexes = { 1, 2 };
            double_test = arrayLibrary.swap(double_test, int_swapIndexes);
            Console.WriteLine("swap value");
            for (int i = 0; i < double_test.Length; i++)
            {
                Console.WriteLine(double_test[i]);
            }

            Console.WriteLine("\n");
            //this will show the highest number of a array (only works with a double array)
            Console.WriteLine("max: " + arrayLibrary.max(double_test));
            //this will show the lowest number of a array (only works with a double array)
            Console.WriteLine("min: " + arrayLibrary.min(int_swapIndexes));
            //this will show the average of a array (only works with a double array)
            Console.WriteLine("average: " + arrayLibrary.average(double_test));

            //makes a array a double array (so that you can use the features that only work with double arrays)
            double[] double_swapIndexes = arrayLibrary.doubleParse(int_swapIndexes);
        }
    }
}
