namespace CSharpPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1

            IGigantosaurus gigantosaurus = new Gigantosaurus();
            gigantosaurus.Roar();

            Console.WriteLine();

            IGigantosaurus loudGigantosaurus = new LoudGigantosaurusDecorator(gigantosaurus);
            loudGigantosaurus.Roar();

            Console.WriteLine();

            IGigantosaurus extraLoudGigantosaurus = new ExtraLoudGigantosaurusDecorator(gigantosaurus);
            extraLoudGigantosaurus.Roar();

            Console.WriteLine();

            #endregion

            #region Task2

            IDeveloper unicycleDeveloper = new UnicycleDeveloper();
            IVehicle unicycle = unicycleDeveloper.Create();
            unicycle.PrintInfo();

            Console.WriteLine();

            IDeveloper motorcycleDeveloper = new MotorcycleDeveloper();
            IVehicle motorcycle = motorcycleDeveloper.Create();
            motorcycle.PrintInfo();

            Console.WriteLine();

            IDeveloper carDeveloper = new CarDeveloper();
            IVehicle car = carDeveloper.Create();
            car.PrintInfo();

            Console.WriteLine();

            IDeveloper truckDeveloper = new TruckDeveloper();
            IVehicle truck = truckDeveloper.Create();
            truck.PrintInfo();

            #endregion
        }
    }
}