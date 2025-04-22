# PWSH playground


powershell doesn't support extension methods as that's just C# syntactic sugar. so you have to create a bridge class.


```csharp
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

![image](https://github.com/user-attachments/assets/e7ec6b2a-b71a-4cef-86f1-659909d5544a)

