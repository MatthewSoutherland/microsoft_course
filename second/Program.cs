using System;

// Remove Exclamation marks

static string RemoveExclamationMarks(string s)
{
    return s.Replace("!", "");
}

Console.WriteLine(RemoveExclamationMarks("hello!"));