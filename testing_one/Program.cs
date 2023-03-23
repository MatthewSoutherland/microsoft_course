using System;

string value = "abc123";
char[] valueArray = value.ToCharArray();
Console.WriteLine(valueArray);
Array.Reverse(valueArray);
Console.WriteLine(valueArray);
string result = new string(valueArray);
Console.WriteLine(result);
