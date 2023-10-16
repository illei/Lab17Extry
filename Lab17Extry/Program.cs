// See https://aka.ms/new-console-template for more information
using Lab17Extry.Shop;
using Lab17Extry.ShopResources;

Console.WriteLine("Hello, World!");

using var ctx =  new ShopDBContext();

var categorie = ctx.Categories.FirstOrDefault( c => c.Name == "Salamuri");
var manufacturer = ctx.Manufacturers.FirstOrDefault(c => c.Name == "Boresc");


Console.WriteLine($"{Shop.GetTotaValue()}");
Console.WriteLine($"Total value by Category:{Shop.GetTotaValue(categorie)}");
Console.WriteLine($"Total value by Manufacturer:{Shop.GetTotaValue(manufacturer)}");


