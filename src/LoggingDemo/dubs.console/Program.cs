
using dubs.logging;

var logger = new Logger();

logger.Info("This is an info message.");
logger.Warning("This is a warning message.");
logger.Error("This is an error message.");
logger.Debug("This is a debug message.");
logger.Critical("This is a critical message.");
logger.Trace("This is a trace message.");

logger.Info("Press any key to exit...");
Console.ReadKey();
