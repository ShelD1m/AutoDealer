namespace AutoDealer.Entites;

public class Sale
{
    /// <summary>
    /// Id сделки
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Id автомобиля в сделке
    /// </summary>
    public int CarId { get; set; }

    /// <summary>
    /// Id человека в сделке
    /// </summary>
    public int ClientId { get; set; }

    /// <summary>
    /// Дата совершения сделки
    /// </summary>
    public DateTime Date { get; set; }

    /// <summary>
    /// Итоговая цена сделки
    /// </summary>
    public decimal FinalPrice { get; set; }
}