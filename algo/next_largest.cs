using System;

/* Create a function that takes a positive integer and returns the next bigger 
number that can be formed by rearranging its digits. For example:

  12 ==> 21
 513 ==> 531
2017 ==> 2071
*/

static long NextBiggerNumber(long n)
{

    // Convert the integer to a string so we can work with its digits
    string digits = n.ToString();

    // Start from the right-most digit and find the first digit that is smaller than the digit to its right
    var i = digits.Length - 2;
    while (i >= 0 && digits[i] >= digits[i + 1])
    {
        i--;
    }

    if (i < 0)
    {
        // If we didn't find any digit to swap, the number can't be rearranged to form a bigger number
        return -1;
    }

    // Find the smallest digit to the right of i that is greater than the digit at i
    var j = digits.Length - 1;
    while (digits[j] <= digits[i])
    {
        j--;
    }

    // Swap the digits at i and j
    char[] charArray = digits.ToCharArray();
    char temp = charArray[i];
    charArray[i] = charArray[j];
    charArray[j] = temp;
    digits = new string(charArray);

    // Reverse the digits to the right of i
    charArray = digits.Substring(i + 1).ToCharArray();
    Array.Reverse(charArray);
    digits = digits.Substring(0, i + 1) + new string(charArray);

    return long.Parse(digits);
}


Console.WriteLine(NextBiggerNumber(1234));
// 2 numbers = 2 comb
// 3 numbers (123) = (123, 132, 213, 231, 312, 321) 6 comb
// 4 numbers (1234) = (1234, 1243, 1324, 1342, 1423, 1432) 24 comb