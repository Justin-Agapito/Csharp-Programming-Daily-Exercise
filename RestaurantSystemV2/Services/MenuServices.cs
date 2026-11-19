using RestaurantSystemV2.Models;

namespace RestaurantSystemV2.Services
{
    class Menu
    {
        List<MenuModel> _menu = new List<MenuModel>
        {
          new MenuModel {Id = 1, Name = "Limited Time Offers", },
          new MenuModel {Id = 2, Name = "Chicken Nuggets", },
          new MenuModel {Id = 3, Name = "Chickenjoy Fried Chicken", },
          new MenuModel {Id = 4, Name = "Chicken Sandwiches", },
          new MenuModel {Id = 5, Name = "Meal Deals", },
          new MenuModel {Id = 6, Name = "Perfect Pairs", },
          new MenuModel {Id = 7, Name = "Family Meals", },
          new MenuModel {Id = 8, Name = "Chicken Tenders", },
          new MenuModel {Id = 9, Name = "Burgers", },
          new MenuModel {Id = 10, Name = "Jolly Spaghetti", },
          new MenuModel {Id = 11, Name = "Palabok Fiesta", },
          new MenuModel {Id = 12, Name = "Burger Steak", },
          new MenuModel {Id = 13, Name = "Sides", },
          new MenuModel {Id = 14, Name = "Drinks", },
          new MenuModel {Id = 15, Name = "Desserts", }  
        };

        public void DisplayMenu()
        {
            Console.WriteLine("****************************************");
            Console.WriteLine("           WELCOME TO JOLLIBEE          ");
            Console.WriteLine("****************************************");
            foreach (MenuModel item in _menu)
            {
                Console.WriteLine($"{item.Id}. {item.Name}");
            }
        }
    }
}