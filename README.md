# PWSH playground


powershell doesn't support extension methods as that's just C# syntactic sugar. so you have to create a bridge class.


## code
```csharp

// extension method class

public static class LoggerExtensions
{
    public static void LogInfo(this string message)
    {
        Console.WriteLine($"[INFO][extension] {DateTime.Now}: {message}");
    }
 
    public static void LogWarning(this string message)
    {
        Console.WriteLine($"[WARNING][extension] {DateTime.Now}: {message}");
    }
...
 }

// bridge class
 public class LoggerExtensionsBridge
    {

        public static void Log(string level, string message)
        {
            switch (level.ToLower())
            {
                case "info":
                    message.LogInfo();
                    break;
                case "warn":
                    message.LogWarning();
                    break;
...
    }
  }
}
```


```pwsh
# usage in pwsh


function Info($message) {
    [dubs.logging.LoggerExtensionsBridge]::Log("info", "$message")
}

function Warn($message) {
    [dubs.logging.LoggerExtensionsBridge]::Log("warn", "$message")
}

...

Info "this is a message"

```

## works
![image](https://github.com/user-attachments/assets/e7ec6b2a-b71a-4cef-86f1-659909d5544a)

## note

you'd want to put these info, warn, errorm, critical etc messages in a powershell module(packaged with dll) in artifactory and pull during the gha workflow runs.

