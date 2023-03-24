// See https://aka.ms/new-console-template for more information

/* This program will reverse the order of a message. Turn it into
a charArray count the o's and back to a stringArray*/

string message = "The quick brown fox jumps over the lazy dog.";

char[] letterMessage = message.ToCharArray();

Array.Reverse(letterMessage);

int letterCount = 0;
foreach (char i in letterMessage)
{
    if (i == 'o')
    {
        letterCount++;
    }
}

string outputMessage = new String(letterMessage);

Console.WriteLine(outputMessage);
Console.WriteLine($"'o' appears {x} times.");