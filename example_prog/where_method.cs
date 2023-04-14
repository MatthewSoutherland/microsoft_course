using System;
using System.Collections;
using System.Linq;

int[] myArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

List<int> myList = myArr.Where(x => x < 5).ToList();

foreach (int item in myList)
{
    Console.WriteLine(item);
}