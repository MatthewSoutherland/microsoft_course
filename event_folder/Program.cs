using System;

class Program
{
    static void Main(string[] args)
    {
        // Create instances of the Counter and Listener classes
        Counter counter = new Counter();
        Listener listener = new Listener();

        // Subscribe the listener to the Counter's CountReached event
        listener.Subscribe(counter);

        // Start counting and trigger the event
        counter.StartCounting();

        // Keep the console window open
        Console.ReadLine();
    }
}
