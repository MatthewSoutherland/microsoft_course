using System;
using System.Collections.Generic;

/* You need to round the answer to 2 decimal places and return it as String.
If the given value is 0 then it should return 0.00
You will only be given Natural Numbers as arguments.
Series: 1 + 1/4 + 1/7 + 1/10 + 1/13 + 1/16 +... */

static string seriesSum(int n)
{
    if (n.ToString() == "0")
    {
        return "0.00";
    }
    else
    {
        decimal count = 4m;
        decimal tally = 1m;
        for (int i = 1; i < n; i++)
        {
            tally += 1 / count;
            count += 3;
        }
        return $"{tally:N}";
    }
}
Console.WriteLine(seriesSum(2));


// double sum = 0;
// for (int i = 0, divider = 1; i < n; i++, divider += 3)
// {
//     sum += 1.0 / divider;
// }
// return $"{sum:f2}";
