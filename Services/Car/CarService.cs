using AutoDealer.Repositories.Car;

namespace AutoDealer.Services.Car;

using Entites;

public class CarService : ICarService
{
    private readonly ICarRepository _carRepository;
    public CarService(ICarRepository carRepository) => _carRepository = carRepository;
    public void AddCar(int id, string brand, string model, decimal price)
    {
        _carRepository.Add(new Car{Id = id, Brand = brand, Model = model, Price = price});
    }
    public IReadOnlyList<Car> GetAllCars()
    {
        return _carRepository.GetAll();
    }
}