using System;
using Array_Library;

namespace ShowCase
{
    class Program
    {
        static void Main()
        {
            double[] double_add = { 5.4, 9.6, 135.6 };
            //adds a value to the array
            double_add = arrayLibrary.add(double_add, 2.5235);
            Console.WriteLine("add value");
            for (int i = 0; i < double_add.Length; i++)
            {
                Console.WriteLine(double_add[i]);
            }
            //this will remove the index 0 from the array (in this case 5.4)
            double[] double_remove = { 5.4, 9.6, 135.6 };
            double_remove = arrayLibrary.remove(double_remove, 0);
            Console.WriteLine("remove value");
            for (int i = 0; i < double_remove.Length; i++)
            {
                Console.WriteLine(double_remove[i]);
            }
            //this will swap index 1 and two which means that they change from position to the others position
            double[] double_swap = { 5.4, 9.6, 135.6 };
            int[] int_swapIndexes = { 1, 2 };
            double_swap = arrayLibrary.swap(double_swap, int_swapIndexes);
            Console.WriteLine("swap value");
            for (int i = 0; i < double_swap.Length; i++)
            {
                Console.WriteLine(double_swap[i]);
            }
            Console.WriteLine("limited add");
            //this will remove the oldest of the array and will then add the nieuw input
            double[] double_limited = { 5.4, 9.6, 135.6 };
            double_limited = arrayLibrary.limitedAdd(double_limited, 5.4);
            for (int i = 0; i < double_limited.Length; i++)
            {
                Console.WriteLine(double_limited[i]);
            }
            Console.WriteLine("insert");
            //this will insert into a array a new value
            double[] double_insert = { 5.4, 9.6, 135.6 };
            double_insert = arrayLibrary.insert(double_insert, 69,1);
            for (int i = 0; i < double_insert.Length; i++)
            {
                Console.WriteLine(double_insert[i]);
            }
            Console.WriteLine("\n");
            int[] int_test = { 5, -3, 7, 19, -26 };
            //this will show the highest number of a array (returns a double)
            Console.WriteLine("max: " + arrayLibrary.max(int_test));
            //this will show the lowest number of a array (returns a double)
            Console.WriteLine("min: " + arrayLibrary.min(int_test));
            //this will show all the numbers added up (returns a double)
            Console.WriteLine("added up: " + arrayLibrary.sum(int_test));
            //this will show the average of a array (returns a double)
            Console.WriteLine("average: " + arrayLibrary.average(int_test));

            //makes a array a double array (so that you can use the features that only work with double arrays)
            double[] double_swapIndexes = arrayLibrary.doubleParse(int_test);
        }
    }
}
