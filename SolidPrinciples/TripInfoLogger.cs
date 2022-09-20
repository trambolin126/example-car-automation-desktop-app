using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.Lib
{
    public class TripInfoLogger
    {
        private readonly ILogger logger;

        public TripInfoLogger(ILogger logger)
        {
            this.logger = logger;
        }

        public void Log(string logInfo)
        {
            logger.Log(logInfo);
        }        
    }

    public interface ILogger
    {
        void Log(string logInfo);
    }

    public class LocalStorageLogger : ILogger
    {
        public void Log(string logStr)
        {
            Console.WriteLine("The Exception is Logged to Local Storage.");
        }
    }

    public class LocalServerLogger : ILogger
    {
        public void Log(string logInfo)
        {
            Console.WriteLine("The Exception is Logged to Istanbul Server.");
        }
    }

    public class GermanyLogger : ILogger
    {
        public void Log(string logStr)
        {
            Console.WriteLine("The Exception is Logged to Germany Server.");
        }
    }
}
