using Serilog;

namespace WorkerService1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var logPath = "D:\\R&D\\WorkerService1\\log.txt";

            Log.Logger = new LoggerConfiguration()
                .WriteTo.File(logPath, rollingInterval: RollingInterval.Day)
                .CreateLogger();

            IHost host = Host.CreateDefaultBuilder(args)
                .UseWindowsService() // for configure windows service
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddHostedService<Worker>();
                })
                .ConfigureLogging((hostContext, logging) =>
                {
                    // Set the logger to the one you configured earlier
                    logging.AddSerilog(); // for track the loh
                })
                .Build();

            host.Run();
        }
    }
}