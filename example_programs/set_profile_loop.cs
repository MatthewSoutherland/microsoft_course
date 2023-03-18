using System;

bool runLoop = true;
string usersRole = "User";
while (runLoop)
{
    Console.WriteLine($"Enter (A)(M)(U)\n(A)Administrator\n(M)Manager\n(U)User");
    string role = Console.ReadLine();
    try
    {
        role = role.Trim().ToLower();
        if (role == "a")
        {
            usersRole = "Administrator";
            runLoop = false;
        }
        else if (role == "m")
        {
            usersRole = "Manager";
            runLoop = false;
        }
        else if (role == "u")
        {
            usersRole = "User";
            runLoop = false;
        }
        else
        {
            Console.Write("N"); Thread.Sleep(100); Console.Write("O"); Thread.Sleep(100); Console.Write("T"); Thread.Sleep(100); Console.Write(" "); Thread.Sleep(100); Console.Write("V"); Thread.Sleep(100); Console.Write("A"); Thread.Sleep(100); Console.Write("L"); Thread.Sleep(100); Console.Write("I"); Thread.Sleep(100); Console.Write("D"); Thread.Sleep(100); Console.Write(" "); Thread.Sleep(1000); Console.Write($"FAGGOT!\n");
        }
    }
    catch (System.Exception)
    {
        Console.WriteLine("Your value was null!!!!!");
    }
    Thread.Sleep(1000);
}

Console.WriteLine($"Your role is {usersRole}. Thank you!");