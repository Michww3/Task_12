class Program
{
    static void Main (string[] args)
    {
        var autoResetEvent = new AutoResetEvent(false);
        //Thread thread1 = new Thread(ThreadWork1);
        //Thread thread2 = new Thread(ThreadWork2);

        //thread1.Start();
        //thread2.Start();
        ThreadPool.QueueUserWorkItem(ThreadWork1);
        ThreadPool.QueueUserWorkItem(ThreadWork2);

        autoResetEvent.WaitOne();

        Console.WriteLine("Unreachable text");
    }

    static void ThreadWork1(object state)   
    {
        Console.WriteLine("Work1");
    }
    static void ThreadWork2(object state)
    {
        Console.WriteLine("Work2");
    }
}