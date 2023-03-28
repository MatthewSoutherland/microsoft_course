﻿using System;
using System.Text.RegularExpressions;

static string Longest(string s1, string s2)
{
    string s3 = s1 + s2;
    string result = new string(s3.OrderBy(c => c).ToArray());
    string final = result[0].ToString();
    for (int i = 1; i < result.Length; i++)
    {
        if (result[i] != result[i - 1])
        {
            final += result[i];
        }
    }
    string output = Regex.Replace(final, "[^a-zA-Z]+", "");
    return output;
}
Console.WriteLine(Longest("xyaabbbcc3ccdefww", "xxxxyyyyabklmopq"));
