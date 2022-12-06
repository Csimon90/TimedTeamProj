public class Program_UI
{
    private readonly Menu_Repository _mRepo = new Menu_Repository();

    public void Run()
    {
        RunApplication();
        
    }

    public void RunApplication()
    {
        
        bool isRunning = true;
        while (isRunning)
        {
            Console.Clear();
            System.Console.WriteLine("Welcome to Komodo Cafe!" +
            "Please choose one of the following\n" + 
            "1. Create Menu \n" + 
            "2. Get Menu by Id \n" +
            "3. Delete Existing Menu \n" +
            "4. List all items on the Menu \n" +
            "0. Close Application \n");
        
        
        string userInput = Console.ReadLine();

        switch (userInput)
        {
            case "1":
                CreateMenu();
                break;
            case "2":
                GetMenuItemById();
                break;
            case "3":
                DeleteExistingMenu();
                break;
            case "4":
                ListAllItemsOnTheMenu();
                break;
            case "0":
                isRunning = CloseApp();
            break;
            default:
            System.Console.WriteLine("Invalid choice, Try again");
            System.Console.WriteLine("PressAnyKeyToContinue");
            break;

        }

         void CreateMenu()
        {
            Console.Clear();
            MenuItem item = new MenuItem();

            Console.WriteLine("Enter the name of the new meal");
            item.mealName = Console.ReadLine();
        
            Console.WriteLine("Enter the description of the new meal");
            item.mealDescription = Console.ReadLine();

            Console.WriteLine("Enter the ingredients of the meal");
            item.mealIngredients = Console.ReadLine();

            Console.WriteLine("Enter the price of the new meal");
            item.mealPrice = decimal.Parse(Console.ReadLine());

            if(_mRepo.AddItemToMenu(item))
            {
                System.Console.WriteLine("Success!");
            }
            else
            {
                System.Console.WriteLine("Fail.");
            }
    
            Console.WriteLine("The menu meal was added to the list\n");
            Console.ReadKey();
            
        }

         void GetMenuItemById()
        {
            Console.Clear();
            //we ask the user to give us an Id
            Console.WriteLine("Please enter a existing item by Id.\n");
          
            //what ever they input will be turned into a number
            //and stored into the userInput variable
            int userInput = int.Parse(Console.ReadLine());

            //make a call to the database based one the "userInput" value
            MenuItem item = _mRepo.GetMenuItem(userInput);

            System.Console.WriteLine(item);
            Console.ReadKey();
      
        }

         void DeleteExistingMenu()
        {
            Console.Clear();
            Console.WriteLine("Please choose what to delete.");
            int userInput = int.Parse(Console.ReadLine());
            MenuItem item = _mRepo.GetMenuItem(userInput);

            if (_mRepo is null)
            {
                Console.WriteLine($"The Menu Number: {userInput} does not exisist \n");
            }
            else 
            {
                if(_mRepo.DeleteItemFromMenu(userInput))
            {
                Console.WriteLine("Success!");           
            }
            else 
            {
                Console.WriteLine("Failed");
            }
            Console.ReadKey();
        }
        
        
           
        }
         void ListAllItemsOnTheMenu()
        {
            Console.Clear();
            foreach (var item in _mRepo.GetAllMenuItem())
            {
                System.Console.WriteLine(item);
            }
            Console.ReadKey();
        }      

         void PressAnyKeyToContinue()
        {
            System.Console.WriteLine("Press any Key to Continue");
            Console.ReadLine();
        }
    }
}

    private bool CloseApp()
    {
        Console.Clear();
        System.Console.WriteLine("Thanks for using the application.");
        Console.ReadKey();
        return false;
    }
}