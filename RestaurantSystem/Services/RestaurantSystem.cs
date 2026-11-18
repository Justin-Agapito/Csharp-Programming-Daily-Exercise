using RestaurantSystem.Models;

namespace RestaurantSystem.Services
{
    //Encapsulation
    // Grouping the related data and methods together
    public class RestaurantService
    {
        public void DisplayMenu()
        {
            //Displaying the restaurant menu
            MenuItemModel Burger = new MenuItemModel();

            Burger.Id = 1;
            Burger.Name = "Cheese Burger";
            Burger.Price = 120.00m;
            Burger.Category = "Burger";

            Console.WriteLine($"=======================");


        }
    }
}