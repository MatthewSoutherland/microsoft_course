using System;

int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();
Console.WriteLine(message);

string third = "5";
string fourth = "7";
int sum = int.Parse(third) + int.Parse(fourth);
Console.WriteLine(sum);

string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result);

// Casting
decimal myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");

int myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}");

// Casting vs converting
int value3 = (int)1.5m; // casting truncates
Console.WriteLine(value3);

int value4 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value4);

string value = "102";
int resultTwo = 0;
if (int.TryParse(value, out resultTwo))
{
    Console.WriteLine($"Measurement: {resultTwo}");
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}