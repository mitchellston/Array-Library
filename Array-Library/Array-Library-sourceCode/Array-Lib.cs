﻿using System;

namespace Array_Library
{
    public class arrayLibrary
    {
        public class inputError : Exception
        {
            public inputError(string message)
            {
            }
        }   
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
            if (index > inputArray.Length)
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
                throw new ArgumentException("There can only be two indexes in the indexes array!");
            }
            if (indexes.Length < indexes[0] || indexes.Length < indexes[1])
            {
                throw new ArgumentException("A index that you want to swap isn't in the array!");
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

            for (int i = 0; i < inputArray.Length; i++)
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
                if (double_max < inputArray[i])
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
