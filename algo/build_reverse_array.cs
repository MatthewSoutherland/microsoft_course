using System;

/* Build a function that returns an array of integers from n to 1 where n>0.
Example : n=5 --> [5,4,3,2,1] */

static int[] ReverseSeq(int n)
{
    int[] myArr = new int[n];

    for (int i = n, j = 0; i >= 1; i--)
    {
        myArr[j] = i;
        j++;
    }

    return myArr;
}

// return Enumerable.Range(1, n).Reverse().ToArray();
// return new int[n].Select(_ => n--).ToArray();