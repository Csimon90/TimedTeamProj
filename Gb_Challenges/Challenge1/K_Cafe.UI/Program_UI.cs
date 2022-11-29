public class Program_UI
{
    

    public void Run()
    {
        RunApplication();
        
    }

    public void RunApplication()
    {
        
        bool isRunning = true;
        while (isRunning)
        {
            System.Console.WriteLine("Welcome to Komodo Cafe!" +
            "Please choose one of the following\n" + 
            "Create Menu \n" + 
            "Update Menu \n" +
            "Delete Existing Menu \n" +
            "List all items on the Menu \n");
        }
        
        string userInput = Console.ReadLine();

        switch (userInput)
        {
            case "1":
                CreateMenu();
                break;
            case "2":
                UpdateMenu();
                break;
            case "3":
                DeleteExistingMenu();
                break;
            case "4":
                ListAllItemsOnTheMenu();
                break;
            default:
            System.Console.WriteLine("Invalid choice, Try again");
            System.Console.WriteLine("PressAnyKeyToContinue");
            break;

        }

         void CreateMenu()
        {

            Console.WriteLine("Enter the name of the new meal");

            Console.WriteLine("Enter the number of the new meal");
        
            Console.WriteLine("Enter the description of the new meal");

            Console.WriteLine("Enter the ingredients of the meal");

            Console.WriteLine("Enter the price of the new meal");
    
            Console.WriteLine("The menu meal was added to the list\n");
            
        }

         void UpdateMenu()
        {
          
            Console.WriteLine("Enter the name of the meal that you'd like to update.\n");

            Console.WriteLine("Enter the new name of the meal.\n");
            
            Console.WriteLine("Enter the new number of the meal.\n");

            Console.WriteLine("Enter the new description of the meal.\n");
         
            Console.WriteLine("Enter the new ingredients of the meal.\n");
        
            Console.WriteLine("Enter the new price of the meal.\n");
            
            Console.WriteLine("Your meal was successfully submitted.\n");
               
            
        }

         void DeleteExistingMenu()
        {
           
                Console.WriteLine("The item could not be deleted");
        
           
        }
         void ListAllItemsOnTheMenu()
        {

        }      

         void PressAnyKeyToContinue()
        {
            System.Console.WriteLine("Press any Key to Continue");
            Console.ReadLine();
        }
    }
    }