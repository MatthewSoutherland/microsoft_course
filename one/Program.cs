using System;

/* 
Sum all the numbers of a given array ( cq. list ), except the highest and the lowest element ( by value, not by index! ).
The highest or lowest element respectively is a single element at each edge, even if there are more than one with the same value.
*/

static int Sum(int[] numbers)
{
    numbers.Order();
    foreach (int num in numbers)
        Console.WriteLine(num);
    return 0;
}
Sum(new int[1, 3, 4, 5, 6, 2]);