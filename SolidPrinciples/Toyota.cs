namespace SolidPrinciples.Lib
{
    public class Toyota : BaseCar
    {
        public override double GetCostPerKM()
        {
            return 0.75;
        }

        public void Go()
        {
            Console.WriteLine("Toyota is now going...");
        }

        public void Stop()
        {
            Console.WriteLine("Toyota has stopped...");
        }
    }
}