
using dubs.logging;


// non-static class
var logger = new Logger();

logger.Info("This is an info message.");
logger.Warning("This is a warning message.");
logger.Error("This is an error message.");
logger.Debug("This is a debug message.");
logger.Critical("This is a critical message.");
logger.Trace("This is a trace message.");


//extension methods
"[extension] This is an info message.".LogInfo();
"[extension] This is a warning message.".LogWarning();
"[extension] This is an error message.".LogError();
"[extension] This is a debug message.".LogDebug();
"[extension] This is a critical message.".LogCritical();
"[extension] This is a trace message.".LogTrace();

logger.Info("Press any key to exit...");
Console.ReadKey();

