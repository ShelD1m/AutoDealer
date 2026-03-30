namespace AutoDealer.Repositories.Client;

using Entites;

public class ClientRepository : IClientRepository
{
    private readonly List<Client> _clients = new();
    private int _nextId = 1;

    public IReadOnlyList<Client> GetAll() => _clients;

    public void Add(Client client)
    {
        client.Id = _nextId++;
        _clients.Add(client);
    }
}