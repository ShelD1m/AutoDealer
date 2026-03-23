namespace AutoDealer.Repositories.Car;
using Entites;

public class CarRepository : ICarRepository
{
   private readonly List<Car> _cars = new();
   public IReadOnlyList<Car> GetAll() => _cars;

   public void Add(Car car)
   {
      _cars.Add(car);
   }
}