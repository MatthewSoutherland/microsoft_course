using System;
using System.Collections.Generic;

/* An isogram is a word that has no repeating letters, consecutive or non-consecutive. 
Implement a function that determines whether a string that contains only letters is an isogram. 
Assume the empty string is an isogram. Ignore letter case. */

static bool IsIsogram(string word)
{
    word = word.ToLower();

    // Create a HashSet to store the unique characters in the word
    HashSet<char> uniqueChars = new HashSet<char>();

    foreach (char c in word)
    {
        // If the character is already in the HashSet, the word is not an isogram
        if (uniqueChars.Contains(c))
        {
            return false;
        }
        else
        {
            // Otherwise, add the character to the HashSet
            uniqueChars.Add(c);
        }
    }
    return true;
}
Console.WriteLine(IsIsogram("aba"));

// return str.ToLower().Distinct().Count()==str.Length;