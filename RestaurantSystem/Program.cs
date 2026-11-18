
using RestaurantSystem.Services;

class Program
{
    static void Main(string[] args)
    {
        MenuService menu = new MenuService();

        menu.DisplayMenu();
    }
}