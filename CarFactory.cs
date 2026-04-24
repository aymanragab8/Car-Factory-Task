namespace CarFactory
{
    public class CarFactory
    {

        private ICarEngine CreateCarEngine(string carEngine)
        {
            carEngine = carEngine.ToLower();
            switch (carEngine)
            {
                case "gas":
                    return new GasEngineCar();

                case "electric":
                    return new ElectricEngineCar();

                case "hybrid":
                    return new HybridEngine();

                default:
                    throw new ArgumentException($"Engine '{carEngine}' isn't valid");
            }
        }

        public Car CreateCar(string carEngine)
        {
            ICarEngine engine = CreateCarEngine(carEngine);
            Console.WriteLine($"Car created with {engine}");
            return new Car(engine);
        }

        public void ReplaceEngine(Car car, string carEngine)
        {
            ICarEngine newEngine = CreateCarEngine(carEngine);
            car.SetCarEngine(newEngine);
        }
    }
}