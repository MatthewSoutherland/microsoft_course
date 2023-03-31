using System;

/* Given an array of integers, find the one that appears an odd number of times.
There will always be only one integer that appears an odd number of times. */

// a = 97, z = 122, A = 65, Z = 90

static int find_it(int[] seq)
{
    int oddInt = 0;
    for (int i = 0; i < seq.Length; i++)
    {
        int count = seq.Count(c => c == seq[i]);
        Console.WriteLine($"count: {count} seq[i]: {seq[i]}");
        if (count % 2 == 1)
        {
            oddInt = seq[i];
        }
    }
    return oddInt;
}
Console.WriteLine(find_it(new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 }));

// return seq.GroupBy(x => x).Single(g => g.Count() % 2 == 1).Key;

// return  seq.First(x => seq.Count(s => s == x) % 2 == 1);

// return seq.ToList()
//   .GroupBy(x => x) //Group by each element in the array
//   .Where(x => (x.Count() % 2) != 0) //Find grouped odd numbers
//   .Select(x => x.First())
//   .FirstOrDefault(); //since array will only contain 1 odd number, get first one