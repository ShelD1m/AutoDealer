using AutoDealer.Dto;

namespace AutoDealer.Services.Sale;

public interface ISaleService
{
    void SellCar(int carId, int clientId, decimal finalPrice);
    IEnumerable<ClientTotalResult> GetTopClients();
}