

using Microsoft.Extensions.Logging;


using var loggerFactory = LoggerFactory.Create(builder =>
{

    builder.AddFilter("Default", LogLevel.Information)
  .AddConsole();

});

ILogger logger = loggerFactory.CreateLogger<Program>();

logger.LogInformation("Info log..");
logger.LogWarning("Warning log..");
logger.LogError("Error log..");