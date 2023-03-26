using System;

string inputString = "The quick brown fox jumps over the lazy dog";
string[] wordsToMatch = { "fox", "cat", "dog", "bird" };

// Split the input string into a words array
string[] wordsInString = inputString.Split(' ');

// Check if any of the words in the string match the words in the array
foreach (string word in wordsInString)
{
    if (Array.IndexOf(wordsToMatch, word) >= 0)
    {
        Console.WriteLine("Match found: " + word);
    }
}
