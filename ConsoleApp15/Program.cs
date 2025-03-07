// See https://aka.ms/new-console-template for more information

using ConsoleApp15;

using (ShopContext context = new ShopContext())
{
    context.Database.EnsureCreated();
}
// AddCategories();
GetCategories();
// void AddCategories()
// {
//     var category = new Category { Id =1 ,Name = "Porn" };
//     var category1 = new Category { Id = 2,Name = "Play" };
//     var category2 = new Category { Id = 3,Name="Books" };
//     using var context = new ShopContext();
//     context.Categories.AddRange(category, category1, category2);
//     context.SaveChanges();
// }
void GetCategories()
{
    using var context = new ShopContext();
    var categories = context.Categories.ToList();
    foreach (var item in categories)
    {
        Console.WriteLine($"Categories:{item.Name}");
    }
}