namespace AutoDealer.Repositories.Client;

using Entites;

public class ClientRepository : IClientRepository 
{
    private readonly List<Client> _clients = new();
    
    public IReadOnlyList<Client> GetAll() => _clients;

    public void Add(Client client) => _clients.Add(client);
}