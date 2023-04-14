using System;
/*
Implement the function unique_in_order which takes as argument a sequence and returns a list of items without any elements with the same value next to each other and preserving the original order of elements.

For example:

uniqueInOrder("AAAABBBCCDAABBB") == {'A', 'B', 'C', 'D', 'A', 'B'}
uniqueInOrder("ABBCcAD")         == {'A', 'B', 'C', 'c', 'A', 'D'}
uniqueInOrder([1,2,2,3,3])       == {1,2,3} */

using System.Collections.Generic;

static IEnumerable<MyType> UniqueInOrder<MyType>(IEnumerable<MyType> iterable)
{
    List<MyType> result = new List<MyType>();

    MyType prev = default(MyType);
    bool firstIteration = true;

    foreach (MyType item in iterable)
    {
        if (firstIteration || !EqualityComparer<MyType>.Default.Equals(prev, item))
        {
            result.Add(item);
            prev = item;
            firstIteration = false;
        }
    }

    return result;
}

var guy = UniqueInOrder("AAABBBBCCDAABBB");
string myString = String.Join(" ", guy);
Console.WriteLine(myString);

