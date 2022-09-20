// See https://aka.ms/new-console-template for more information

using SolidPrinciples.Lib;
using static System.Net.Mime.MediaTypeNames;

namespace CarAutomation
{
    class Program
    {
        

        static void Main(string[] args)
        {

            TestClass test = new TestClass();

            // Ask the user to choose an option.
            OptionSelector();
            Console.WriteLine("1 - Drive Car");
            Console.WriteLine("2 - Calculate Trip Cost");
            OptionWaiter();

            // Use a switch statement to do.
            switch (Console.ReadLine())
            {
                case "1":
                    RunCar();
                    break;
                case "2":
                    CalculateTripCost();
                    break;
            }

            OptionCloser();

        }

        static void OptionSelector()
        {
            Console.WriteLine("");
            Console.WriteLine("Choose an option from the following list:");
        }

        static void OptionWaiter()
        {
            Console.WriteLine("");
            Console.Write("Your option? ");
        }

        static void OptionCloser()
        {
            Console.WriteLine("");
            Console.Write("Press any key to close the console app...");
            Console.ReadKey();
        }

        static Double InputWaiter(String inputName)
        {
            Console.WriteLine("");
            Console.Write($"Input your {inputName}: ");

            return Convert.ToDouble(Console.ReadLine());
        }

        static String SelectCar()
        {

            TestClass test = new TestClass();

            // Ask the user to choose an option.
            OptionSelector();
            Console.WriteLine("1 - BMW");
            Console.WriteLine("2 - Mercedes");
            Console.WriteLine("3 - Toyota");
            OptionWaiter();

            // Use a switch statement to do.
            switch (Console.ReadLine())
            {
                case "1":
                    return "bmw";
                case "2":
                    return "mercedes";
                case "3":
                    return "toyota";
                default:
                    return "";
            }

        }

        static void RunCar()
        {
            TestClass test = new TestClass();
            test.RunCar(SelectCar());
        }

        static void CalculateTripCost()
        {
            TestClass test = new TestClass();
            test.CalculateTripCost(SelectCar(), InputWaiter("Trip KM"));
        }
        
    }
}
