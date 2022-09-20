using System.Net.Mail;

namespace SolidPrinciples.Lib
{
    public class BMW : BaseCar, IEmailSendable, IMultipleEmailSendable
    {
        public override double GetCostPerKM()
        {
            return 1.5;
        }

        public void Go()
        {
            Console.WriteLine("BMW is now going...");
        }

        public void Stop()
        {
            Console.WriteLine("BMW has stopped...");
        }

        public void SendTripInfoEmailToDriver(DriverInfo driver)
        {
            if (!string.IsNullOrEmpty(driver.EmailAddress))
            {
                Console.WriteLine("Trip info Email has sent.");
            }
        }

        public void SendTripIntoEmailToDrivers(List<DriverInfo> drivers)
        {
            foreach (var driver in drivers)
            {
                SendTripInfoEmailToDriver(driver);
            }
        }
    }
}