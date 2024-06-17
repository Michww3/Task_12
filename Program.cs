class Program
{
    static void Main (string[] args)
    {
        AutoResetEvent autoResetEvent = new AutoResetEvent(false);
        Thread thread1 = new Thread(ThreadWork1);
        Thread thread2 = new Thread(ThreadWork2);

        thread1.Start();
        thread2.Start();

        autoResetEvent.WaitOne();

        Console.WriteLine("Unreachable text");
    }

    static void ThreadWork1()   
    {
        Console.WriteLine("Work1");
    }
    static void ThreadWork2()
    {
        Console.WriteLine("Work2");
    }
}