namespace CarFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarFactory factory = new CarFactory();

            Car gasCar = factory.CreateCar("gas");
            gasCar.Start();
            gasCar.Accelerate();
            gasCar.Accelerate();
            gasCar.Brake();
            gasCar.Brake();
            gasCar.Stop();
            Console.WriteLine("*****************************************\n");

            Car elctricCar = factory.CreateCar("electric");
            elctricCar.Start();
            elctricCar.Accelerate();
            elctricCar.Accelerate();
            elctricCar.Brake();
            elctricCar.Brake();
            elctricCar.Stop();
            Console.WriteLine("*****************************************\n");

            Car hybridCar = factory.CreateCar("hybrid");
            hybridCar.Start();
            hybridCar.Accelerate();
            hybridCar.Accelerate();
            hybridCar.Accelerate();
            hybridCar.Brake();
            hybridCar.Brake();
            hybridCar.Brake();
            hybridCar.Stop();
            Console.WriteLine("*****************************************\n");


            Car car = factory.CreateCar("gas");
            car.Start();
            car.Accelerate();
            car.Brake();
            car.Stop();
            factory.ReplaceEngine(car, "electric");
            car.Start();
            car.Accelerate();
            car.Brake();
            car.Stop();

            Console.WriteLine("*****************************************");
            Console.WriteLine("Troubleshooting...\n");

            Car testCar = factory.CreateCar("gas");
            Console.WriteLine("Stop before start:");
            testCar.Stop();

            Console.WriteLine("\nAccelerate before start:");
            testCar.Accelerate();

            testCar.Start();
            Console.WriteLine("\nStart again while running:");
            testCar.Start();

            Console.WriteLine("\nStop while moving:");
            testCar.Accelerate();
            testCar.Stop();

            Console.WriteLine("\nReach max speed (200):");
            for (int i = 0; i < 12; i++)
                testCar.Accelerate();
        }
    }
}