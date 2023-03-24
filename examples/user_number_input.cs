using System;

bool userInput = true;

while (userInput)
{
    Console.WriteLine("Enter a number between 5 and 10");
    string userNumber = Console.ReadLine();
    try
    {
        int num = int.Parse(userNumber);
        if (num < 11 && num > 4)
        {
            userInput = false;
        }
    }
    catch (System.Exception)
    {
        Console.WriteLine("Invalid input. Please enter a valid integer.");
    }
    Thread.Sleep(1000);
}

