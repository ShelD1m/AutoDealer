using AutoDealer.Consoles;
using AutoDealer.Repositories.Car;
using AutoDealer.Repositories.Client;
using AutoDealer.Repositories.Sale;
using AutoDealer.Services.Car;
using AutoDealer.Services.Client;
using AutoDealer.Services.Sale;

var carRepo = new CarRepository();
var clientRepo = new ClientRepository();
var saleRepo = new SaleRepository();

ICarService carService = new CarService(carRepo);
IClientService clientService = new ClientService(clientRepo);
ISaleService saleService = new SaleService(saleRepo, clientRepo);

carService.AddCar(1, "Toyota", "Camry", 3000000m);
carService.AddCar(2, "BMW", "X5", 7500000);
carService.AddCar(3, "Lada", "Vesta", 1200000);

clientService.AddClient(101, "Иван","Иванов", "+7(999)123-45-67");
clientService.AddClient(102, "Анна", "Смирнова","+7(900)000-00-00");

saleService.SellCar(1, 101, 2900000);
saleService.SellCar(2, 101, 7500000);
saleService.SellCar(3, 102, 1200000);

var menu = new AppMenu(carService, clientService, saleService);
menu.Run();