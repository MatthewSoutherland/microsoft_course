using System;
using System.Linq;

// Return min and max of an array

static int[] minMax(int[] lst)
{
    int[] newList = new int[2];
    newList[0] = lst.Min();
    newList[1] = lst.Max();
    return newList;
}
var guy = minMax(new int[5] { 1, 2, 3, 4, 5 });
string myString = String.Join(" ", guy);
Console.WriteLine(myString);

// return new int[] {lst.Min(), lst.Max()};
// return new int[] { lst.Min(), lst.Max() };