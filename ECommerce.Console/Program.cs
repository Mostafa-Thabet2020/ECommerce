// See https://aka.ms/new-console-template for more information
using ECommerce.Console.Models;
using ECommerce.Console.Parent;
using ECommerce.Console.Services;

Console.WriteLine("Hello, World!");

//CRUD Create Read Update Delete
GovernroteService governroteService = new GovernroteService();
CityService cityService = new CityService();    
//Governrote governrote = new Governrote() { Name = "Cairo" };
//governroteService.Add(governrote);

City city = new City();
city.Name = "Maadi";
city.governrote = governroteService.Get(1);
cityService.Add(city);