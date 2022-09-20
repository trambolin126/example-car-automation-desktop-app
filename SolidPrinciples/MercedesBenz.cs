using SolidPrinciples.Lib.SmsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.Lib
{
    public class MercedesBenz: BaseCar, ISmsSendable, IEmailSendable
    {
        public override double GetCostPerKM()
        {
            return 2;
        }

        public void Go()
        {
            Console.WriteLine("Mercedes is now going...");
        }

        public void Stop()
        {
            Console.WriteLine("Mercedes has stopped...");
        }

        public void SendTripInfoEmailToDriver(DriverInfo driver)
        {
            if (!string.IsNullOrEmpty(driver.EmailAddress))
            {
                Console.WriteLine("Trip info Email has sent.");
            }
        }

        public void SendTripInfoSmsToDriver(DriverInfo driver)
        {
            if (!string.IsNullOrEmpty(driver.PhoneNumber))
            {
                Console.WriteLine("Trip info SMS has sent.");
            }
        }

        
    }
}
