using SolidPrinciples.Lib.CustomExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.Lib
{
    public class TestClass
    {
        public TestClass()
        {

        }

        public void CalculateTripCost(String carName, Double tripKM)
        {
            var calculator = new FuelCostCalculator();

            switch (carName)
            {
                case "bmw":
                    Console.WriteLine($"Total cost for {carName} is {calculator.Calculate(new BMW(), tripKM)} TL");
                    break;
                case "mercedes":
                    Console.WriteLine($"Total cost for {carName} is {calculator.Calculate(new MercedesBenz(), tripKM)} TL");
                    break;
                case "toyota":
                    Console.WriteLine($"Total cost for {carName} is {calculator.Calculate(new Toyota(), tripKM)} TL");
                    break;
            }

        }

        public void RunCar(String carName)
        {
            try
            {
                switch (carName)
                {
                    case "bmw":
                        var bmw = new BMW();
                        bmw.Go();
                        bmw.Stop();
                        bmw.SendTripInfoEmailToDriver(new DriverInfo());
                        break;
                    case "mercedes":
                        var mercedes = new MercedesBenz();
                        mercedes.Go();
                        mercedes.Stop();
                        mercedes.SendTripInfoEmailToDriver(new DriverInfo());
                        mercedes.SendTripInfoSmsToDriver(new DriverInfo());
                        break;
                    case "toyota":
                        var toyota = new Toyota();
                        toyota.Go();
                        toyota.Stop();
                        break;
                }  
            }
            catch (EngineStartException ex)
            {
                new TripInfoLogger(new GermanyLogger()).Log(ex.Message);
            }
            catch (AirPressureException ex)
            {
                new TripInfoLogger(new LocalStorageLogger()).Log(ex.Message);
            }
            catch (Exception ex)
            {
                new TripInfoLogger(new LocalServerLogger()).Log(ex.Message);
            }
        }

    }
}
