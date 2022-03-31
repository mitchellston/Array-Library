using System;
using Array_Library;

namespace ShowCase
{
    class Program
    {
        static void Main()
        {
            //adds a value to the array
            double[] double_add = { 5.4, 9.6, 135.6 };
            double_add = double_add.add(2.5235);
            Console.WriteLine("add value");
            for (int i = 0; i < double_add.Length; i++)
            {
                Console.WriteLine(double_add[i]);
            }
            
            //this will remove the index 0 from the array (in this case 5.4)
            double[] double_remove = { 5.4, 9.6, 135.6 };
            double_remove = double_remove.remove(0);
            Console.WriteLine("remove value");
            for (int i = 0; i < double_remove.Length; i++)
            {
                Console.WriteLine(double_remove[i]);
            }
            
            //this will swap index 1 and two which means that they change from position to the others position
            double[] double_swap = { 5.4, 9.6, 135.6 };
            int[] int_swapIndexes = { 1, 2 };
            double_swap = double_swap.swap(int_swapIndexes);
            Console.WriteLine("swap value");
            for (int i = 0; i < double_swap.Length; i++)
            {
                Console.WriteLine(double_swap[i]);
            }
            Console.WriteLine("limited add");
            
            //this will remove the oldest of the array and will then add the nieuw input
            double[] double_limited = { 5.4, 9.6, 135.6 };
            double_limited = double_limited.limitedAdd(5.4);
            for (int i = 0; i < double_limited.Length; i++)
            {
                Console.WriteLine(double_limited[i]);
            }
            Console.WriteLine("insert");
            
            //this will insert into a array a new value
            double[] double_insert = { 5.4, 9.6, 135.6 };
            double_insert = double_insert.insert(69,1);
            for (int i = 0; i < double_insert.Length; i++)
            {
                Console.WriteLine(double_insert[i]);
            }
            Console.WriteLine("\n");
            
            int[] int_test = { 5, -3, 7, 19, -26 };
            
            //this will show the highest number of a array (returns a double)
            Console.WriteLine("max: " + int_test.max());
            
            //this will show the lowest number of a array (returns a double)
            Console.WriteLine("min: " + int_test.min());
            
            //this will show all the numbers added up (returns a double)
            Console.WriteLine("added up: " + int_test.sum());
            
            //this will show the average of a array (returns a double)
            Console.WriteLine("average: " + int_test.average());

        }
    }
}
