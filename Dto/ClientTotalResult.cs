namespace AutoDealer.Dto;

public class ClientTotalResult
{
    /// <summary>
    /// Имя и фамилия клиента
    /// </summary>
    public string ClientName { get; set; }

    /// <summary>
    /// Количество купленных автомобилей
    /// </summary>
    public int CarsBought { get; set; }

    /// <summary>
    /// Потраченная сумма
    /// </summary>
    public decimal TotalSpent { get; set; }
}