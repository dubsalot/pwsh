namespace dubs.logging;

public class Logger : IDisposable
{
    public void Log(string message)
    {
        Console.WriteLine($"[LOG] {DateTime.Now}: {message}");
    }
    public void Info(string message)
    {
        Console.WriteLine($"[INFO] {DateTime.Now}: {message}");
    }

    public void Warning(string message)
    {
        Console.WriteLine($"[WARNING] {DateTime.Now}: {message}");
    }

    public void Error(string message)
    {
        Console.WriteLine($"[ERROR] {DateTime.Now}: {message}");
    }

    public void Debug(string message)
    {
        Console.WriteLine($"[DEBUG] {DateTime.Now}: {message}");
    }

    public void Critical(string message)
    {
        Console.WriteLine($"[CRITICAL] {DateTime.Now}: {message}");
    }

    public void Trace(string message)
    {
        Console.WriteLine($"[TRACE] {DateTime.Now}: {message}");
    }
    
    public void Dispose()
    {
        // Dispose of any resources if necessary
    }

}
