namespace CarFactory
{
    public class GasEngineCar : ICarEngine
    {
        public int CarSpeed { get; private set; }

        public void Increase()
        {
            CarSpeed++;
        }

        public void Decrease()
        {
            if (CarSpeed > 0)
                CarSpeed--;
        }

        public override string ToString()
        {
            return $"GasEngineCar";
        }
    }
}