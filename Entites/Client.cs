namespace AutoDealer.Entites;

public class Client
{
    /// <summary>
    /// Id человека
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Имя человека
    /// </summary>
    public string FirstName { get; set; }

    /// <summary>
    /// Фамилия человека
    /// </summary>
    public string LastName { get; set; }

    /// <summary>
    /// Номер телефона человека
    /// </summary>
    public string Phone { get; set; }
}