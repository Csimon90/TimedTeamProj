

public class Menu_Repository
{
    
    private readonly List<MenuItem> _menuItemDB = new List<MenuItem>();
    private int _count;

    public Menu_Repository()
    {
        Seed();
    }

    public bool AddItemToMenu(MenuItem menuItem)
    {
        if(menuItem != null)
        {
         _count++;
         menuItem.mealNumber=_count;
         _menuItemDB.Add(menuItem);
         return true;
        }
        else
        {
         return false;
        }
     }
    public List<MenuItem> GetAllMenuItem()
    {
        return _menuItemDB;
    }
    public MenuItem GetMenuItem(int mealNumber)
    {
        foreach (MenuItem menuItem in _menuItemDB)
        {
            if (menuItem.mealNumber == mealNumber )
            {
                return menuItem;
            }
        }
        return null;
    }
    public bool DeleteItemFromMenu(int id)
    {
        MenuItem item = GetMenuItem(id);
        return _menuItemDB.Remove(item);

    }


    private void Seed()
    {
        var itemA = new MenuItem("Big Mac", "I'm a Big Mac!","Patty, special sauce, cheese",9.99m);
        var itemB = new MenuItem("Double Cheese Burger", "I'm a Double Cheese Burger","Patty, cheese",8.99m);
        var itemC = new MenuItem("Quarter  Pounder", "I'm a Quarter  Pounder","Patty, onions, cheese",7.99m);

        AddItemToMenu(itemA);
        AddItemToMenu(itemB);
        AddItemToMenu(itemC);
    }
}
