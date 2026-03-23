namespace AutoDealer.Repositories.Sale;

using Entites;

public interface ISaleRepository
{
    IReadOnlyList<Sale> GetAll();
    void Add(Sale sale);
    int GetNextId();
}