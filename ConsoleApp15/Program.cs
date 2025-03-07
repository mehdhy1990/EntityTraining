// See https://aka.ms/new-console-template for more information

using ConsoleApp15;

using (ShopContext context = new ShopContext())
{
    context.Database.EnsureCreated();
}
// AddCategories();
GetCategories();
void AddCategories()
{
    var category = new Category {Id = "4",Name = "Porn2" };
   
    using var context = new ShopContext();
    context.Categories.Add(category);
    context.SaveChanges();
}
void GetCategories()
{
    using var context = new ShopContext();
    var categories = context.Categories.ToList();
    categories.Select(c=>c.Name).ToList().ForEach(c=>Console.WriteLine(c));
}