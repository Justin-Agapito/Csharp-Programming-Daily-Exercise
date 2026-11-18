//DISPLAYS THE MENU ONLY
using RestaurantSystem.Models;

namespace RestaurantSystem.Services
{
    //Encapsulation
    // Grouping the related data and methods together
    public class MenuService
    {
        private readonly List<MenuItemModel> _menu = new List<MenuItemModel>
        {
          new MenuItemModel { Id = 1, Name = "Limited Time Offers", Price = 120.00m, Category = "Limited Time Offers"},
          new MenuItemModel { Id = 2, Name = "Chicken Nuggets", Price = 120.00m, Category = "Chicken Nuggets"},
          new MenuItemModel { Id = 3, Name = "Chicken Joy Fried Chicken", Price = 120.00m, Category = "Chicken Joy Fried Chicken"}, 
          new MenuItemModel { Id = 4, Name = "Chicken Sandwiches", Price = 120.00m, Category = "Chicken Sandwiches"}, 
          new MenuItemModel { Id = 5, Name = "Meal Deals", Price = 120.00m, Category = "Meal Deals"}, 
          new MenuItemModel { Id = 6, Name = "Perfect Pairs", Price = 120.00m, Category = "Perfect Pairs"}, 
          new MenuItemModel { Id = 7, Name = "Family Meal", Price = 120.00m, Category = "Family Meal"}, 
          new MenuItemModel { Id = 8, Name = "Chicken Tenders", Price = 120.00m, Category = "Chicken Tenders"},
          new MenuItemModel { Id = 9, Name = "Jolly Spaghetti", Price = 120.00m, Category = "Jolly Spaghetti"},
          new MenuItemModel { Id = 10, Name = "Palabok Fiesta", Price = 120.00m, Category = "Palabok Fiesta"},
          new MenuItemModel { Id = 11, Name = "Burger Steak", Price = 120.00m, Category = "Burger Steak"},
          new MenuItemModel { Id = 12, Name = "Sides", Price = 120.00m, Category = "Sides"},
          new MenuItemModel { Id = 13, Name = "Drinks", Price = 120.00m, Category = "Drinks"},
          new MenuItemModel { Id = 14, Name = "Desserts", Price = 120.00m, Category = "Desserts"},
          new MenuItemModel { Id = 15, Name = "Burgers", Price = 120.00m, Category = "Burgers"},
        };

        public List<MenuItemModel> GetAllItems()
        {
            return _menu;
        }

        public void DisplayMenu()
        {
            Console.WriteLine("===================================");
            Console.WriteLine("       WElCOME TO JOLLIBEE         ");
            Console.WriteLine("===================================");

            foreach (MenuItemModel menuItem in _menu)
            {
                Console.
            }
        }
    }
}