namespace AutoDealer.Repositories.Client;
using AutoDealer.Entites;
public interface IClientRepository
{
    IReadOnlyList<Client> GetAll();
    void  Add(Client client);
}