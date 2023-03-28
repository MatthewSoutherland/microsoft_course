using System;

/* How can you tell an extrovert from an introvert at NSA?
Va gur ryringbef, gur rkgebireg ybbxf ng gur BGURE thl'f fubrf.

I found this joke on USENET, but the punchline is scrambled. Maybe you can decipher it?
According to Wikipedia, ROT13 is frequently used to obfuscate jokes on USENET.

For this task you're only supposed to substitute characters. Not spaces, punctuation, numbers, etc. */

// a = 97, z = 122, A = 65, Z = 90

static string Rot13(string input)
{
    char[] inputCharArray = input.ToCharArray();
    int[] inputNumberArray = new int[inputCharArray.Length];
    int[] outputNumberArray = new int[inputCharArray.Length];
    char[] outputCharArray = new char[inputCharArray.Length];

    for (int i = 0; i < inputCharArray.Length; i++)
    {
        char c = Convert.ToChar(inputCharArray[i]);
        inputNumberArray[i] = c;
    }

    for (int i = 0; i < inputNumberArray.Length; i++)
    {
        if (inputNumberArray[i] >= 97 && inputNumberArray[i] <= 122)  // if lowercase
        {
            if (inputNumberArray[i] + 13 > 122)
            {
                outputNumberArray[i] = ((inputNumberArray[i] + 13) - 122 + 96);
            }
            else
            {
                outputNumberArray[i] = inputNumberArray[i] + 13;
            }
        }
        else if (inputNumberArray[i] >= 65 && inputNumberArray[i] <= 90)
        {
            if (inputNumberArray[i] + 13 > 90)
            {
                outputNumberArray[i] = ((inputNumberArray[i] + 13) - 90 + 64);
            }
            else
            {
                outputNumberArray[i] = inputNumberArray[i] + 13;
            }
        }
        else
        {
            outputNumberArray[i] = inputNumberArray[i];
        }
    }
    for (int i = 0; i < outputNumberArray.Length; i++)
    {
        outputCharArray[i] = Convert.ToChar(outputNumberArray[i]);
    }

    return String.Concat(outputCharArray);
}
Console.WriteLine(Rot13("EBG13 rknzcyr."));
