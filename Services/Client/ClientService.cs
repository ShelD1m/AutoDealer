using AutoDealer.Repositories.Client;

namespace AutoDealer.Services.Client;


using Repositories.Client;

public class ClientService(IClientRepository clientRepository) : IClientService
{
    public void AddClient(int id, string firstName, string lastName, string phone)
        {
            clientRepository.Add(new Entites.Client{FirstName = firstName, LastName = lastName, Phone = phone});
        }
    
        public IReadOnlyList<Entites.Client> GetAllClient() =>  clientRepository.GetAll();
}