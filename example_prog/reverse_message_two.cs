using System;


static string ReverseWords(string str)
{
    string[] message = str.Split(' ');
    string[] newMessage = new string[message.Length];
    for (int i = 0; i < message.Length; i++)
    {
        char[] letters = message[i].ToCharArray();
        Array.Reverse(letters);
        newMessage[i] = new string(letters);
    }
    string result = String.Join(" ", newMessage);
    return result;
}


Console.WriteLine(ReverseWords("hello everyone out there."));
// return string.Join(" ", str.Split(' ').Select(i => new string(i.Reverse().ToArray())));
