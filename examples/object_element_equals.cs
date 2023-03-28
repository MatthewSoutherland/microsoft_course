using System;

/* You will be given an array a and a value x. All you need to do is check 
whether the provided array contains the value. Array can contain numbers or 
strings. X can be either. Return true if the array contains the value, false if not.*/

static bool Check(object[] a, object x)
{
    foreach (object element in a)
    {
        Console.WriteLine(element);
        if (element.Equals(x))
        {
            return true;
        }
    }
    return false;
}
Console.WriteLine(Check(new object[] { 80, 117, 115, 104, 45, 85, 112, 115 }, 45));