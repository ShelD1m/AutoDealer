namespace AutoDealer.Repositories.Sale;

using Entites;

public class SaleRepository : ISaleRepository 
{
    private readonly List<Sale> _sales = new();
    private int _nextId = 1;
    
    public IReadOnlyList<Sale> GetAll() => _sales;

    public void Add(Sale sale) => _sales.Add(sale);
    public int GetNextId() => _nextId++;
}