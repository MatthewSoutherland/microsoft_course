public class Counter
{
    public event EventHandler CountReached;

    public string StartCounting()
    {
        for (int i = 1; i <= 5; i++)
        {
            if (i == 5)
            {
                OnCountReached(EventArgs.Empty);
            }
        }
        return "Done.";
    }

    protected virtual void OnCountReached(EventArgs e)
    {
        CountReached?.Invoke(this, e);
    }
}

public class Listener
{
    public void Subscribe(Counter counter)
    {
        counter.CountReached += OnCountReached;
    }

    private void OnCountReached(object sender, EventArgs e)
    {
        Console.WriteLine("Count reached 5.");
    }
}
