using AutoDealer.Repositories.Car;

namespace AutoDealer.Services.Car;

using Entites;

public class CarService : ICarService
{
    private readonly ICarRepository _carRepository;
    public CarService(ICarRepository carRepository) => _carRepository = carRepository;
    public void AddCar(string brand, string model, decimal price)
    {
        _carRepository.Add(new Car{Brand = brand, Model = model, Price = price});
    }
    public IReadOnlyList<Car> GetAllCars()
    {
        return _carRepository.GetAll();
    }
}