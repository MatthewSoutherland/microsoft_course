using System;


static string SwitchItUp(int number)
{
    switch (number)
    {
        case 1: "One";
        case 2: "Two";
        case 3: "Three";
        case 4: "Four";
        case 5: "Five";
        case 6: "Six";
        case 7: "Seven";
        case 8: "Eight";
        case 9: "Nine";
        default: "Zero";
    };
    return number;
}
var result = SwitchItUp(1);
Console.WriteLine(result);
