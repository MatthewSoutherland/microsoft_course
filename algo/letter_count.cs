using System;
using System.Collections.Generic;

/* Check to see if a string has the same amount of 'x's and 'o's. The method must 
return a boolean and be case insensitive. The string can contain any char.*/

static bool XO(string input)
{
    char targetCharX = 'x';
    char targetCharO = 'o';

    int count_x = input.ToLower().Count(c => c == targetCharX);
    int count_o = input.ToLower().Count(c => c == targetCharO);
    // Console.WriteLine($"count_x: {count_x} count_o: {count_o}");
    return count_o == count_x;
}
Console.WriteLine(XO("xOxOxXoO"));

// return input.ToLower().Count(i => i == 'x') == input.ToLower().Count(i => i == 'o');