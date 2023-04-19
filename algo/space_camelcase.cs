using System;
using System.Linq;
using System.Collections;

/*Complete the solution so that the function will break up camel casing, using a space between words.
Example
"camelCasing"  =>  "camel Casing"
 */

static string BreakCamelCase(string str)
{
    string message = "";
    foreach (char letter in str)
    {
        if (char.IsUpper(letter))
        {
            message = message + " " + letter;
        }
        else
        {
            message += letter;
        }
    }
    return message;
}
string result = BreakCamelCase("helloMyNameIs").ToString();
Console.WriteLine(result);

// public static string BreakCamelCase(string str) =>
// new Regex("([A-Z])").Replace(str, " $1");

// return string.Concat(str.Select(c => Char.IsUpper(c) ? " " + c : c.ToString()));