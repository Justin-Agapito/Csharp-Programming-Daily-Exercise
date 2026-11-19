using RestaurantSystem.Models;
using RestaurantSystem.Services;

Menu menu = new Menu();
menu.DisplayMenu();

Console.WriteLine("Enter your order: ");
string? input = Console.ReadLine();

if (int.TryParse(input, out int choice))
{
    MenuModel? selected = menu.FindbyId(choice);

    if (selected == null)
    {
        Console.WriteLine("The item is not in the menu");
    }
    else
    {
        Console.WriteLine($"You ordered: {selected.Name} - P{selected.Price:N2}");
    }
}