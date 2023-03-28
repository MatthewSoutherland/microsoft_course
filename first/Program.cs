using System;

static string ToggleCase(string input)
{

    return new String(input.Select(c => (char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c))).ToArray());
}

string result = ToggleCase("Hello WoRlD");
Console.WriteLine(result);