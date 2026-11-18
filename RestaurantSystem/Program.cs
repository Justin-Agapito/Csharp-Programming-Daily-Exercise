
using RestaurantSystem.Services;

class Program
{
    static void Main(string[] args)
    {
        RestaurantService restaurant = new RestaurantService();

        restaurant.DisplayMenu();
    }
}