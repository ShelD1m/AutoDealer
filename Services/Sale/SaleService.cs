using AutoDealer.Repositories.Client;
using AutoDealer.Repositories.Sale;
using AutoDealer.Entites;
using AutoDealer.Dto;

namespace AutoDealer.Services.Sale;

public class SaleService : ISaleService
{
    private readonly IClientRepository _clientRepository;
    private readonly ISaleRepository _saleRepository;
    public SaleService(ISaleRepository saleRepository, IClientRepository clientRepository)
    {
        _saleRepository = saleRepository;
        _clientRepository = clientRepository;
    }

    public void SellCar(int carId, int clientId, decimal finalPrice)
    {
        var sale = new Entites.Sale
        {
            Id = _saleRepository.GetNextId(),
            CarId = carId,
            ClientId = clientId,
            Date = DateTime.Now,
            FinalPrice = finalPrice,
        };
        _saleRepository.Add(sale);
    }

    public IEnumerable<ClientTotalResult> GetTopClients()
    {
        var clients = _clientRepository.GetAll().ToDictionary(c => c.Id, c => c.FirstName + " " + c.LastName);
        return _saleRepository.GetAll()
            .GroupBy(s => s.ClientId)
            .Select(g => new ClientTotalResult
            {
                ClientName = clients.TryGetValue(g.Key, out var clientName) ? clientName : "Неизвестный",
                CarsBought = g.Count(),
                TotalSpent = g.Sum(s => s.FinalPrice)
            })
            .OrderByDescending(result => result.TotalSpent).ToList();
    }
}