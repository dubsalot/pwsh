# #!/usr/bin/env pwsh


# # Path to your compiled DLL
# $dllPath = "/workspaces/pwsh/src/LoggingDemo/dubs.logging/bin/Debug/net8.0/dubs.logging.dll"

# # Load the assembly
# Add-Type -Path $dllPath

# # Create an instance of the Logger class
# $logger = New-Object dubs.logging.Logger

# # Use the logger methods
# $logger.Info("This is an info message")
# $logger.Warning("This is a warning message")
# $logger.Error("This is an error message")
# $logger.Debug("This is a debug message")
# $logger.Critical("This is a critical message")
# $logger.Trace("This is a trace message")

# $logger.Info("Press any key to exit...")


# # Wait for user input before closing
# $null = $host.UI.RawUI.ReadKey("NoEcho,IncludeKeyDown")
# # Clean up
# $logger.Dispose()
# # End of script



function Info($message) {
    [dubs.logging.LoggerExtensionsBridge]::Log("info", "$message")
}

function Warn($message) {
    [dubs.logging.LoggerExtensionsBridge]::Log("warn", "$message")
}

function ErrorM($message) {
    [dubs.logging.LoggerExtensionsBridge]::Log("error", "$message")
}

function Debug($message) {
    [dubs.logging.LoggerExtensionsBridge]::Log("debug", "$message")
}

function Critical($message) {
    [dubs.logging.LoggerExtensionsBridge]::Log("critical", "$message")
}

function Trace($message) {
    [dubs.logging.LoggerExtensionsBridge]::Log("trace", "$message")
}

# Export-ModuleMember -Function Info, Warn, Error, Debug, Critical, Trace