# Array Library

A C# library that provides a few convenient functions for arrays.<br>
**In packaged-library is the build version. Array-Library is the source code!**

<br>
<br>

# Usage:

### Add value to array:

```C#
using Array_Library;

namespace ShowCase
{
    class Program
    {
        static void Main()
        {
            double[] double_test = { 5.4, 9.6, 135.6 };
            //array = arrayLibrary.add(array, index);
            double_test = arrayLibrary.add(double_test, 2.5235);
            //values double_test: 5.4, 9.6, 135.6, 2.5235
        }
    }
}
```

<br>

### Remove value from array:

```C#
using Array_Library;

namespace ShowCase
{
    class Program
    {
        static void Main()
        {
            double[] double_test = { 5.4, 9.6, 135.6 };
            //var array = arrayLibrary.remove(var array, var index);
            double_test = arrayLibrary.remove(double_test, 0);
            //values double_test: 9.6, 135.6
        }
    }
}
```

<br>

### Swap/ switch values in array:

```C#
using Array_Library;

namespace ShowCase
{
    class Program
    {
        static void Main()
        {
            double[] double_test = { 5.4, 9.6, 135.6 };
            int[] indexes = { 0, 1};
            //var array = arrayLibrary.swap(var array, var indexes);
            double_test = arrayLibrary.swap(double_test, indexes);
            //values double_test: 9.6, 5.4, 135.6
        }
    }
}
```

<br>

### Min/ max (smallest/ biggest) values in array:

```C#
using Array_Library;

namespace ShowCase
{
    class Program
    {
        static void Main()
        {
            double[] double_testMin = { 5.4, 9.6, 135.6 };
            int[] int_testMax = {1, 5, 25};
            double min = arrayLibrary.min(double_testMin);
            double max = arrayLibrary.max(int_testMax);
            Console.WriteLine("min = "+min+" & max = "+max);
            //Console output: min = 5.4 & max = 25
        }
    }
}
```

<br>

### Average:

```C#
using Array_Library;

namespace ShowCase
{
    class Program
    {
        static void Main()
        {
            double[] double_test = { 5.4, 9.6, 135.6 };
            double average = arrayLibrary.average(double_test);
            Console.WriteLine("average = "+average);
            //Console output: average = 50,199999999999996
        }
    }
}
```

<br>

### Convert array to double:

```C#
using Array_Library;

namespace ShowCase
{
    class Program
    {
        static void Main()
        {
            int[] int_test = { 5, 9, 135 };
            double[] converted = arrayLibrary.doubleParse(int_test);
            //Gives var converted the same values as int_test
            //(only diffrence is that converted is a double and not a int)
        }
    }
}
```

<br>
