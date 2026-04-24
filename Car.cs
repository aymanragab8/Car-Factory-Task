namespace CarFactory
{
    public class Car
    {
        private ICarEngine _carEngine;
        private int _carSpeed;
        private bool _isRunning;

        public Car(ICarEngine carEngine)
        {
            _carEngine = carEngine;
            _carSpeed = 0;
            _isRunning = false;
        }
        public void SetCarEngine(ICarEngine carEngine)
        {
            _carEngine = carEngine;
            Console.WriteLine($"Engine replaced with new engine ({_carEngine})");
        }
        public void Start()
        {
            if (_isRunning)
            {
                Console.WriteLine("Car is already running.");
                return;
            }
            _isRunning = true;
            _carSpeed = 0;
            Console.WriteLine($"Car started.");
        }
        public void Stop()
        {
            if (!_isRunning)
            {
                Console.WriteLine("Car is already stopped");
                return;
            }
            if (_carSpeed != 0)
            {
                Console.WriteLine($"Cannot stop, Speed must be 0 first. (Current speed: {_carSpeed} km/h)");
                return;
            }
            _isRunning = false;
            Console.WriteLine("Car stopped");
        }
        public void Accelerate()
        {
            if (!_isRunning)
            {
                Console.WriteLine("Cannot accelerate, Car is not running.");
                return;
            }
            if (_carSpeed == 200)
            {
                Console.WriteLine("Already at max speed (200 km/h).");
                return;
            }
            int steps = 20;
            for (int i = 0; i < steps; i++)
            {
                _carEngine.Increase();
            }
            _carSpeed = Math.Min(_carSpeed + 20, 200);
            Console.WriteLine($"Accelerated (Speed: {_carSpeed} km/h | Engine: {_carEngine})");
        }
        public void Brake()
        {
            if (!_isRunning)
            {
                Console.WriteLine("Cannot brake, Car is not running.");
                return;
            }
            if (_carSpeed == 0)
            {
                Console.WriteLine("Already at 0 km/h.");
                return;
            }
            int steps = 20;
            for (int i = 0; i < steps; i++)
            {
                _carEngine.Decrease();
            }
            _carSpeed = Math.Max(_carSpeed - 20, 0);
            Console.WriteLine($"Braked (Speed: {_carSpeed} km/h | Engine: {_carEngine})");
        }
    }
}