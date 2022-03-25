﻿using System;
namespace arrayLIB
{
    class examples
    {
        static void Main()
        {
            int[] test = { 1, 2, 3 };
            test = arraysHelper.addToArray(test, 26);
            test = arraysHelper.removeFromArray(test, 1);
            int[] indexes = { 2, 0 };
            test= arraysHelper.swapItemsInArray(test, indexes);
            for (int i = 0; i < test.Length; i++)
            {
                Console.WriteLine(test[i]);
            }
            Console.WriteLine("max: " + arraysHelper.max((double[])arraysHelper.doubleParse(test)));
            Console.WriteLine("max: " + arraysHelper.min((double[])arraysHelper.doubleParse(test)));
            Console.WriteLine("average: " + arraysHelper.average((double[])arraysHelper.doubleParse(test)));


        }

    }
    public class arraysHelper
    {

        public static T[] addToArray<T>(T[] inputArray, T inputValue)
        {
            int int_new = inputArray.Length + 1;
            T[] newArray = new T[int_new];
            for (int i = 0; i < inputArray.Length; i++)
            {
                newArray[i] = inputArray[i];
            }
            newArray[int_new - 1] = inputValue;
            return newArray;

        }
        public static T[] removeFromArray<T>(T[] inputArray, int index)
        {
            if(index > inputArray.Length)
            {
                throw new ArgumentException("The array doesn't have a index that big (use addToArray to increase index)");
            }
            int int_new = inputArray.Length - 1;
            T[] newArray = new T[int_new];
            int int_indexLoop = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (i != index)
                {
                    newArray[int_indexLoop] = inputArray[i];
                    int_indexLoop++;
                }
            }
            return newArray;
        }
        public static T[] swapItemsInArray<T>(T[] inputArray, int[] indexes)
        {
            T[] newArray = new T[inputArray.Length];
            if (indexes.Length > 2)
            {
                throw new ArgumentException("Er kunnen maar twee indexes zijn in de indexes array!");
            }
            if (indexes.Length < indexes[0] || indexes.Length < indexes[1])
            {
                throw new ArgumentException("Een index die je wilt swappen is niet in de array!");
            }
            newArray[indexes[0]] = inputArray[indexes[1]];
            newArray[indexes[1]] = inputArray[indexes[0]];
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (i == indexes[0] || i == indexes[1])
                {
                    continue;
                }
                newArray[i] = inputArray[i];

            }
            return newArray;
        }
        public static double[] doubleParse<T>(T[] inputArray)
        {
            double[] newArray = new double[inputArray.Length];
            
            for(int i = 0; i < inputArray.Length; i++)
            {
                newArray[i] = Convert.ToDouble(inputArray[i]);
            }
            return newArray;
            
        }
        public static double max(double[] inputArray)
        {
            double double_max = inputArray[0];
            for (int i = 0; i < inputArray.Length; i++)
            {
                if(double_max < inputArray[i])
                {
                    double_max = inputArray[i];
                }
            }
            return double_max;
        }
        public static double min(double[] inputArray)
        {
            double double_min = inputArray[0];
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (double_min > inputArray[i])
                {
                    double_min = inputArray[i];
                }
            }
            return double_min;
        }
        public static double average(double[] inputArray)
        {
            double double_all = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {

                 double_all += inputArray[i];

            }
            double_all = double_all / inputArray.Length;
            return double_all;
        }
    }
}