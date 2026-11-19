using RestaurantSystem.Models;

namespace RestaurantSystem.Services
{
    class Menu
    {
        List<MenuModel> _menu = new List<MenuModel>
        {
          new MenuModel {Id = 1, Name = "Classic Burger", Price = 50.00m, },
          new MenuModel {Id = 2, Name = "Cheese Burger", Price = 50.00m, },
          new MenuModel {Id = 3, Name = "Beef Burger", Price = 50.00m, },
          new MenuModel {Id = 4, Name = "Chicken Burger", Price = 50.00m, },
          new MenuModel {Id = 5, Name = "Vegan Burger", Price = 50.00m, },
          new MenuModel {Id = 6, Name = "CheeseBurger", Price = 50.00m, },
            
        };

        public void DisplayMenu()
        {
            Console.WriteLine("***********************************");
            Console.WriteLine("        Weclome to Deli's          ");
            Console.WriteLine("***********************************");
            
            foreach (MenuModel item in _menu)
            {
                Console.WriteLine($"{item.Id}. {item.Name} - P{item.Price:N2}");
            }
        }

        public MenuModel? FindbyId(int Id)
        {
            foreach (MenuModel item in _menu)
            {
                if (item.Id == Id)
                {
                    return item;
                }
            }
            return null;
        }
    }
}