using System;

namespace dubs.logging
{
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

        public static void LogError(this string message)
        {
            Console.WriteLine($"[ERROR][extension] {DateTime.Now}: {message}");
        }

        public static void LogDebug(this string message)
        {
            Console.WriteLine($"[DEBUG][extension] {DateTime.Now}: {message}");
        }

        public static void LogCritical(this string message)
        {
            Console.WriteLine($"[CRITICAL][extension] {DateTime.Now}: {message}");
        }

        public static void LogTrace(this string message)
        {
            Console.WriteLine($"[TRACE][extension] {DateTime.Now}: {message}");
        }
    }
    
    // class to bridge extension methods to non-extension method usable from pwsh
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
                case "error":
                    message.LogError();
                    break;
                case "debug":
                    message.LogDebug();
                    break;
                case "critical":
                    message.LogCritical();
                    break;
                case "trace":
                    message.LogTrace();
                    break;
                default:
                    throw new ArgumentException($"Unknown log level: {level}");
            }
        }

        // a more verbose way
        // public static void LogInfo(string message)
        // {
        //     message.LogInfo();
        // }

        // public static void LogWarning(string message)
        // {
        //     message.LogWarning();
        // }

        // public static void LogError(string message)
        // {
        //     message.LogError();
        // }

        // public static void LogDebug(string message)
        // {
        //     message.LogDebug();
        // }

        // public static void LogCritical(string message)
        // {
        //     message.LogCritical();
        // }

        // public static void LogTrace(string message)
        // {
        //     message.LogTrace();
        // }
    }   
}
