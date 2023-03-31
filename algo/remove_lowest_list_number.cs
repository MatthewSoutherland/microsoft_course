using System;
using System.Collections.Generic;

/* Given an array of integers, remove the smallest value. Do not mutate the original array/list. 
If there are multiple elements with the same value, remove the one with a lower index. If you 
get an empty array/list, return an empty array/list.
Don't change the order of the elements that are left. */

static List<int> RemoveSmallest(List<int> numbers)
{
    List<int> modifiedList = new List<int>(numbers);
    int min = modifiedList.Min();
    modifiedList.Remove(min);
    return modifiedList;
}
Console.WriteLine(RemoveSmallest(new List<int> { 1, 2, 3, 1, 1 }));