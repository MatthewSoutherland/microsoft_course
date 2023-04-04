class StudentMath
{

    public int Add(int argOne, int argTwo)
    {
        var output = argOne + argTwo;
        Console.WriteLine("Added: " + output);
        return output;
    }

    public int Subtract(int argOne, int argTwo)
    {
        var output = argOne - argTwo;
        Console.WriteLine("Subtracted: " + output);
        return output;
    }

    public int Divide(int argOne, int argTwo)
    {
        var output = argOne / argTwo;
        Console.WriteLine("Divided: " + output);
        return output;
    }

    public int Multiply(int argOne, int argTwo)
    {
        var output = argOne * argTwo;
        Console.WriteLine("Multiplyed: " + output);
        return output;
    }
}