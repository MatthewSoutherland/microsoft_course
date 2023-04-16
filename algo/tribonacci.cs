using System;
using System.Linq;

// Tribonacci

double[] Tribonacci(double[] signature, int n)
{
    int len = signature.Length;
    if (n == 0)
    {
        return new double[0];
    }
    else if (n == 1)
    {
        Array.Resize(ref signature, 1);
        return signature;
    }
    else if (n == 2)
    {
        Array.Resize(ref signature, 2);
        return signature;
    }
    double[] newSignature = new double[n];
    newSignature[0] = signature[0];
    newSignature[1] = signature[1];
    newSignature[2] = signature[2];
    for (int i = len; i < n; i++)
    {
        var lastNum = newSignature[i - 1];
        var secondLastNum = newSignature[i - 2];
        var thirdLastNum = newSignature[i - 3];
        double addMe = lastNum + secondLastNum + thirdLastNum;
        Console.WriteLine($"third: {thirdLastNum} second: {secondLastNum} last: {lastNum} addme: {addMe}");
        newSignature[i] = addMe;
    }
    return newSignature;
}

var result = Tribonacci(new double[] { 4, 6, 12 }, 2);
var guy = String.Join(',', result);
Console.WriteLine(guy);
