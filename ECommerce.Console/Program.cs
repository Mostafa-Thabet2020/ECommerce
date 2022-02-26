// See https://aka.ms/new-console-template for more information
using ConsoleServices;
using ECommerce.Console;
using Microsoft.EntityFrameworkCore;
using Models;
using Parent;
using Services;
using Shared;

Console.WriteLine("Hello, from ECommerce");

ConsoleService.UserDealing();

#region Examples
// instance
//GovernroteService governroteService = new GovernroteService();//Service that containt actions on model

//Governrote governrote = new Governrote();//Model .. entity .. object
//governrote.Id = 1;
//governrote.Name = "Cairo";
//governroteService.Update(governrote);

//governrote.Name = "Alex";
//governrote.CreatedDate= DateTime.Now;
//EcommorceDbContext DbContext = new EcommorceDbContext();
//DbContext.governrotes.Add(governrote);
//DbContext.SaveChanges();
//Console.WriteLine("Done");
#endregion

//EcommorceDbContext dbContext = new EcommorceDbContext();

// => Arrow function
#region dealing with collection of data
// ToList() function use with collection of object
// ToArray() function use to make array 
//List<City> cities = dbContext.cities.Include(db => db.governrote).ToList();
//List<City> citiesLinq = (from city in dbContext.cities
//                         select city).Include(x => x.governrote).ToList();
//foreach (City city in cities)
//{
//    Console.WriteLine($"city name is {city.Name}\n" +
//        $"it's governrote is {city.governrote.Name}\n");
//}

//List<City> GizeCities = dbContext.cities.Include(x => x.governrote).Where(p => p.GovernroteId == 2).OrderBy(p=>p.Name).ToList();
//List<City> GizaCitiesLionq = (from c in dbContext.cities
//                              where c.GovernroteId == 2 
//                              select c).Include(x => x.governrote).OrderBy(x => x.Name).ToList();
//Console.WriteLine("Gize cities");
//foreach (City city in GizeCities)
//{
//    Console.WriteLine($"city name is {city.Name}\n" +
//        $"it's governrote is {city.governrote.Name}\n");
//}
#endregion

#region single object
////SingleOrDefault() 
//City doki = dbContext.cities.Where(x => x.Id == 4).SingleOrDefault();
//City dokiLinq = (from city in dbContext.cities
//                 where city.Id == 4
//                 select city).SingleOrDefault();
//Console.WriteLine($"single or default of 4 id is{doki.Name}\n");
////FirstOrDefault()
//City FirstRow = dbContext.cities.FirstOrDefault();
//City FirstRowLinq = (from c in dbContext.cities
//                     select c).FirstOrDefault();
//Console.WriteLine($"First row \n id:{FirstRow.Id}. Name: {FirstRow.Name}");
////LastOrDefault()
//City LastRowbyId = dbContext.cities.OrderBy(x=>x.Id).LastOrDefault();
//Console.WriteLine($"Last row by Id \n id:{LastRowbyId.Id}. Name: {LastRowbyId.Name}");

//City LastRowbyName = dbContext.cities.OrderByDescending(x => x.Name).LastOrDefault();
//Console.WriteLine($"Last row by name \n id:{LastRowbyName.Id}. Name: {LastRowbyName.Name}");
#endregion

//int CountOfCitiesRows = dbContext.cities.Count();
//Console.WriteLine($"count of cities {CountOfCitiesRows}");

//int CountOfGizaCities = dbContext.cities.Where(x => x.GovernroteId == 2).Count();
//Console.WriteLine($"Count of giza cities {CountOfGizaCities}");

