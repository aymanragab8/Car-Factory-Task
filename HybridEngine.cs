namespace CarFactory
{
    public class HybridEngine : ICarEngine
    {
        private readonly GasEngineCar _gas = new();
        private readonly ElectricEngineCar _electric = new();

        public int CarSpeed => GetActiveEngine().CarSpeed;

        private ICarEngine GetActiveEngine()
        {
            int currentSpeed = _electric.CarSpeed + _gas.CarSpeed;
            return (_electric.CarSpeed < 50 && _gas.CarSpeed == 0) || (_electric.CarSpeed > 0 && _electric.CarSpeed < 50) ? _electric : _gas;
        }
        public void Decrease()
        {
            int currentSpeed = CarSpeed;
            if (currentSpeed >= 50)
            {
                _gas.Decrease();

                if (_gas.CarSpeed < 50)
                {
                    while (_electric.CarSpeed < _gas.CarSpeed) _electric.Increase();
                    while (_gas.CarSpeed > 0) _gas.Decrease();
                }
            }
            else
            {
                _electric.Decrease();
            }
        }

        public void Increase()
        {
            int currentSpeed = CarSpeed;
            if (currentSpeed < 50)
            {
                _electric.Increase();

                if (_electric.CarSpeed == 50)
                {
                    while (_gas.CarSpeed < _electric.CarSpeed) _gas.Increase();
                    while (_electric.CarSpeed > 0) _electric.Decrease();
                }
            }
            else
            {
                _gas.Increase();
            }
        }
        public override string ToString()
        {
            string activeEngine = CarSpeed < 50 ? "Electric Engine" : "Gas Engine";
            return $"Hybrid Engine ({activeEngine})";
        }

    }
}