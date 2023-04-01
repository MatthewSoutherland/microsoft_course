using System;

static int n_log_n(int n)
{
    int y = n;
    while (n > 1)
    {
        n = Math.Floor(n / 2);
        for (let i = 1; i <= y; i++)
        {
            Console.WriteLine(i);
        }
    }
}