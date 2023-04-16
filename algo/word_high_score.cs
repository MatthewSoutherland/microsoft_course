using System;
using System.Linq;
using System.Collections;

/* Given a string of words, you need to find the highest scoring word.
Each letter of a word scores points according to its position in the alphabet: a = 1, b = 2, c = 3 etc.
For example, the score of abad is 8 (1 + 2 + 1 + 4).
You need to return the highest scoring word as a string.
If two words score the same, return the word that appears earliest in the original string.
All letters will be lowercase and all inputs will be valid.

 */

static string High(string s)
{
    // Create a hashtable for scoring
    Hashtable hashtable = new Hashtable()
    {
        { 'a', 1 },
        { 'b', 2 },
        { 'c', 3 },
        { 'd', 4 },
        { 'e', 5 },
        { 'f', 6 },
        { 'g', 7 },
        { 'h', 8 },
        { 'i', 9 },
        { 'j', 10 },
        { 'k', 11 },
        { 'l', 12 },
        { 'm', 13 },
        { 'n', 14 },
        { 'o', 15 },
        { 'p', 16 },
        { 'q', 17 },
        { 'r', 18 },
        { 's', 19 },
        { 't', 20 },
        { 'u', 21 },
        { 'v', 22 },
        { 'w', 23 },
        { 'x', 24 },
        { 'y', 25 },
        { 'z', 26 }
    };
    string[] words = s.Split(" ");
    int[] wordScore = new int[words.Length];

    for (int i = 0; i < words.Length; i++)
    {
        for (int j = 0; j < words[i].Length; j++)
        {
            if (hashtable.Contains(words[i][j]))
            {
                wordScore[i] += (int)hashtable[words[i][j]];
            }
        }
    }

    // Find index number with highest score
    int indexOfHighScore = 0;
    for (int x = 0; x < wordScore.Length; x++)
    {
        if (wordScore[x] > wordScore[indexOfHighScore])
        {
            indexOfHighScore = x;
        }
    }
    return words[indexOfHighScore].ToString();
}
Console.WriteLine(High("man i need a taxi up to ubud"));
