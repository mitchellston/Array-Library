# Array Library

A C# library that provides a few convenient functions for arrays.<br>
**In packaged-library is the build version. Array-Library is the source code!**

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
            //array = array.add(value);
            double_test = double_test.add(2.5235);
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
            //var array = array.remove(index);
            double_test = double_test.remove(0);
            //values double_test: 9.6, 135.6
        }
    }
}
```

<br>

### Insert value into array:

```C#
using Array_Library;

namespace ShowCase
{
    class Program
    {
        static void Main()
        {
            double[] double_test = { 5.4, 9.6, 135.6 };
            //var array = array.insert(value, index);
            double_test = double_test.insert(12, 1);
            //values double_test: 5.4, 12, 9.6, 135.6
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

            //var array = array.swap(indexes);
            double_test = double_test.swap(indexes);
            //values double_test: 9.6, 5.4, 135.6
        }
    }
}
```

<br>

### Limited add:

#### Removes oldest(index= 0) and moves everything down and adds to the last index the new value!

```C#
using Array_Library;

namespace ShowCase
{
    class Program
    {
        static void Main()
        {
            double[] double_test = { 5.4, 9.6, 135.6 };

            //var array = array.limitedAdd(value);
            double_test = double_test.limitedAdd(15.79);

            

            //values double_test: 9.6, 135.6, 15.79
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
            double min = double_testMin.min();
            double max = int_testMax.max();
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
            double average = double_test.average();
            Console.WriteLine("average = "+average);
            //Console output: average = 50,199999999999996
        }
    }
}
```

<br>

### Sum:

```C#
using Array_Library;

namespace ShowCase
{
    class Program
    {
        static void Main()
        {
            double[] double_test = { 5.4, 9.6, 135.6 };
            double sum = double_test.sum();
            Console.WriteLine("sum = "+sum);
            //Console output: sum = 150,6
        }
    }
}
```
