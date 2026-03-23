namespace AutoDealer.Entites;

public class Car
{
    /// <summary>
    ///  Id автомобиля
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    ///  Марка автомобиля
    /// </summary>
    public string Brand { get; set; }

    /// <summary>
    ///  Модель автомобиля
    /// </summary>
    public string Model { get; set; }

    /// <summary>
    ///  Цена автомобиля
    /// </summary>
    public decimal Price { get; set; }
}