﻿// See https://aka.ms/new-console-template for more information

using ConsoleApp15;

using (ShopContext context = new ShopContext())
{
    context.Database.EnsureCreated();
}
// AddCategories();
GetCategories();

void GetCategories()
{
    using var context = new ShopContext();
    var categories = context.Categories.ToList();
    categories.Select(c=>c.Name).ToList().ForEach(c=>Console.WriteLine(c));
    Console.WriteLine("///////");
    categories.Where(n => categories.Any(p => n.Name.StartsWith("Po"))).ToList().ForEach(c=>Console.WriteLine(c.Name));
}