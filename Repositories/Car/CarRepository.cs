namespace AutoDealer.Repositories.Car;
using Entites;

public class CarRepository : ICarRepository
{
   private readonly List<Car> _cars = new();
   private int _nextId = 1;
   public IReadOnlyList<Car> GetAll() => _cars;

   public void Add(Car car)
   {
      car.Id = _nextId++;
      _cars.Add(car);
   }
}