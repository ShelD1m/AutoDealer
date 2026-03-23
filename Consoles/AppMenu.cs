using AutoDealer.Services.Car;
using AutoDealer.Services.Client;
using AutoDealer.Services.Sale;

namespace AutoDealer.Consoles;

public class AppMenu
{
    private readonly ICarService _carService;
    private readonly IClientService _clientService;
    private readonly ISaleService _saleService;

    public AppMenu(ICarService carService, IClientService clientService, ISaleService saleService)
    {
        _carService = carService;
        _clientService = clientService;
        _saleService = saleService;
    }

    public void Run()
    {
        while (true)
        {
            PrintMenu();
            var key = System.Console.ReadLine()?.Trim() ?? "";
            if (key == "0") break;
            switch (key)
            {
                case "1": ShowCar(); break;
                case "2": ShowClient(); break;
                case "3": SellCarMenu(); break;
                case "4": ShowTopClient(); break;
                default: System.Console.WriteLine("Неизвестный пункт");  break;
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine("Выход...");
    }

    private void PrintMenu()
    {
        System.Console.WriteLine("--- Автосалон ---");
        System.Console.WriteLine("1 - Список автомобилей");
        System.Console.WriteLine("2 - Список клиентов");
        System.Console.WriteLine("3 - Оформить продажу");
        System.Console.WriteLine("4 - ТОП клиентов по тратам");
        System.Console.WriteLine("0 - Выход");
        System.Console.Write("Выбор: ");
    }

    private void ShowCar()
    {
        System.Console.WriteLine("Автомобили в наличии");
        foreach (var c in _carService.GetAllCars())
        {
            System.Console.WriteLine($"{c.Id} {c.Brand} {c.Model} - {c.Price}");
        }
    }

    private void ShowClient()
    {
        System.Console.WriteLine("Клиенты");
        foreach (var c in _clientService.GetAllClient())
        {
            System.Console.WriteLine($"{c.Id} {c.FirstName} {c.LastName} {c.Phone}");
        }
    }

    private void SellCarMenu()
    {
        System.Console.WriteLine("Введите Id машины");
        if (!int.TryParse(System.Console.ReadLine(), out int carId)) return;

        System.Console.WriteLine("Введите Id клиента");
        if (!int.TryParse(System.Console.ReadLine(), out int clientId)) return;

        System.Console.Write("Введите итоговую цену продажи: ");
        if (!decimal.TryParse(System.Console.ReadLine(), out decimal price)) return;

        _saleService.SellCar(carId, clientId, price);
        System.Console.WriteLine("Продажа успешно оформлена");
    }

    private void ShowTopClient()
    {
        System.Console.WriteLine("ТОП Клиентов");
        foreach (var stat in _saleService.GetTopClients())
        {
            System.Console.WriteLine(
                $"{stat.ClientName}: куплено авто - {stat.CarsBought}, потрачено - {stat.TotalSpent:C}");
        }
    }
}