//Observer

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {        
            TemperatureSensor sensor = new TemperatureSensor();
            TemperatureReporter reporter = new TemperatureReporter();
            reporter.StartReporting(monitor);
            monitor.GetTemperature();
        }
    }
}