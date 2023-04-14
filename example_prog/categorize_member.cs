using System;
using System.Collections;

static IEnumerable<string> OpenOrSenior(int[][] data)
{
    List<string> myList = new List<string> { };
    for (int i = 0; i < data.Length; i++)
    {
        if (data[i][0] >= 55 && data[i][1] > 7)
        {
            myList.Add("Senior");
        }
        else
        {
            myList.Add("Open");
        }
    }
    return myList;
}

var guy = OpenOrSenior(new[] { new[] { 45, 12 }, new[] { 55, 21 }, new[] { 19, 2 }, new[] { 104, 20 } });
string myString = String.Join(" ", guy);
Console.WriteLine(myString);