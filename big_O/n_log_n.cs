using System;

static int nLogN(int n)
{
    int y = n;
    while (n > 1)
    {
        n = n / 2;
        for (var i = 1; i <= y; i++)
        {
            Console.WriteLine(i);
        }
    }
    return 0;
}
nLogN(32);