// See https://aka.ms/new-console-template for more information

using ConsoleApp15;

using (ShopContext context = new ShopContext())
{
    context.Database.EnsureCreated();
}

void GetCategories()
{
    using var context = new ShopContext();
    var categories = context.Categories.ToList();
    
}