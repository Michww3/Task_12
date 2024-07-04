class Program
{

    static void Main(string[] args)
    {
        bool EventType = false;

        var autoResetEvent = new AutoResetEvent(SetEventType(EventType));
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
    static int SetWidht(int value)
    {
        return value += 35;
    }
    static bool SetEventType(bool value)
    {
        return value;
    }

}