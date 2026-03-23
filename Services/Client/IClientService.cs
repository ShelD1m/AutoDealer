namespace AutoDealer.Services.Client;

using Entites;

public interface IClientService
{
    IReadOnlyList<Client> GetAllClient();
    void AddClient(int  id, string firstName, string lastName, string phone);
}