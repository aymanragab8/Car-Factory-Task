namespace CarFactory
{
    public interface ICarEngine
    {
        int CarSpeed { get; }
        void Increase();
        void Decrease();
    }
}