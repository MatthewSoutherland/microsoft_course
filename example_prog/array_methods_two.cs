using System;

string value = "abc123";
char[] valueArray = value.ToCharArray();    // creates an array from each character in the string.
Array.Reverse(valueArray);  // reverses the order of the array.

// string result = new string(valueArray);

string result = String.Join(",", valueArray);
Console.WriteLine($"result: {result}");

string[] items = result.Split(',');
Console.WriteLine($"items: {items}");

foreach (string item in items)
{
    Console.WriteLine($"item in loop: {item}");
}