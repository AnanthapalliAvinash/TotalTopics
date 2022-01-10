using System;

namespace DynamicDemo
{
    class Program
    {
        public class Logger
        {
            public void LogInfo(string message)
            {
                Console.WriteLine($"INFO: {message}");
            }
            public void LogWarning(string message)
            {
                Console.WriteLine($"WARNING: {message}");
            }
            public void LogError(string message)
            {
                Console.WriteLine($"ERROR: {message}");
            }
        }
        public class LoggerFactory
        {
            public static Logger GetLogger()
            {
                return new Logger();
            }
        }
        
        static void Main(string[] args)
        {
            dynamic logger = LoggerFactory.GetLogger();
            logger.LogInfo("Hi");
            logger.LogWarning("You are about to enter a time warp");
            logger.LogError("System is malfunctioning");
            //logger.LogTrace("Communication lost");
        }
    }
}
