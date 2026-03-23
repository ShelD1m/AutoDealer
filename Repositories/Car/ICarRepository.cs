namespace AutoDealer.Repositories.Car;

using AutoDealer.Entites;

public interface ICarRepository
{
    IReadOnlyList<Car> GetAll();
    void Add(Car car);
}