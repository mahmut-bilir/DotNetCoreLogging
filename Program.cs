

using Microsoft.Extensions.Logging;
using Serilog;


// using var loggerFactory = LoggerFactory.Create(builder =>
// {

//     builder.AddFilter("Default", LogLevel.Information)
//   .AddConsole();

// });

// ILogger logger = loggerFactory.CreateLogger<Program>();

// logger.LogInformation("Info log..");
// logger.LogWarning("Warning log..");
// logger.LogError("Error log..");


Log.Logger = new LoggerConfiguration()
.MinimumLevel.Information()
.WriteTo.Console()
.WriteTo.File("log/log.txt", rollingInterval: RollingInterval.Day)
.CreateLogger();

Log.Information("Serilog info");
Log.Warning("Serilog warning");
Log.Error("Serilog error");

Log.CloseAndFlush();