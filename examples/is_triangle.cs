using System;

/* Implement a function that accepts 3 integer values a, b, c. The function should 
return true if a triangle can be built with the sides of given length and false in 
any other case. public static bool IsTriangle(int a, int b, int c) */

static bool IsTriangle(int a, int b, int c)
{
    // Check if the sum of any two sides is greater than the third side
    if (a + b > c && a + c > b && b + c > a)
    {
        // If so, the sides can form a triangle
        return true;
    }
    else
    {
        // Otherwise, the sides cannot form a triangle
        return false;
    }
}
Console.WriteLine(IsTriangle(5, 7, 10));