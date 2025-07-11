using singleton;

class Program
{
    static void Main(string[] args)
    {
        Logger s1 = Logger.Instance;
        Logger s2 = Logger.Instance;

        s1.Log("First log message.");
        s2.Log("Second log message.");

        Console.WriteLine(s1 == s2);
    }
}