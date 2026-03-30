namespace AutoDealer.Services.Car;

using Entites;

public interface ICarService
{
    void AddCar(string brand, string model, decimal price);
    IReadOnlyList<Car> GetAllCars();
}