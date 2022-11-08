
using System;


namespace ForestAdventure
{
    class Program
    {
        static void Main(string [] args)
        {
            forestAdventure();
            wakeUp();
        }
        public static void forestAdventure()
        {
            Console.WriteLine("Forest Adventure!");
            Console.WriteLine("Your head is pounding. Light from the sun above the clearing is blinding as you first open your eyes."); 
            Console.WriteLine("After a moment you adjust and you realize you have woken up deep within an old growth forest."); 
            Console.WriteLine("You do not remember how you came to be at this place.");
            Console.WriteLine("You begin to realize you don't even know your own name.");
            Console.WriteLine("Just as the panic of being alone in the woods begins to bubble you notice three items and a weathered scroll with shaky,");
             Console.WriteLine("You unroll and begin to read:  'For all your riches and petty greed, a troubled path you shall lead."); 
            Console.WriteLine("Only one favor I will treat, select one object by your feet.'");
            Console.WriteLine("As you read the last line the scroll burst to flame and leaves nothing but ash and a whisper of smoke.");
            Console.WriteLine("You turn your attention to the objects before you.");   

        }
        public static void wakeUp()
        {
            string choice;
            
             Console.WriteLine("What do you choose?"); 
             Console.WriteLine("1. The Sword");
             Console.WriteLine("2. The Bow");
             Console.WriteLine("3. The Wand");
             choice = Console.ReadLine();
             Console.Clear();
        

             switch (choice)
             {
                case "1":
                case "The Sword":
                    {
                         Console.WriteLine("Upon picking up your choice the other two disappear.");
                         Console.WriteLine("Just as the scroll before them.");
                         Console.WriteLine("With great shaking and rumbling a path opens up in the woods as the trees pop and groan to bend around it.");
                         Console.WriteLine("The path is dark. There is no way to know where it leads but you have no other options.");
                         Console.WriteLine("You take a breath. Steady your courage and make for the path.");
                         first();
                         break;
                    }

                case "2":
                case "The Bow":
                    {
                         Console.WriteLine("Upon picking up your choice the other two disappear.");
                        Console.WriteLine("Just as the scroll before them.");
                        Console.WriteLine("With great shaking and rumbling a path opens up in the woods as the trees pop and groan to bend around it.");
                        Console.WriteLine("The path is dark. There is no way to know where it leads but you have no other options.");
                        Console.WriteLine("You take a breath. Steady your courage and make for the path.");
                        second();
                        break;
                    }

                case "3":
                case "The Wand":
                    {
                        Console.WriteLine("Upon picking up your choice the other two disappear.");
                        Console.WriteLine("Just as the scroll before them.");
                        Console.WriteLine("With great shaking and rumbling a path opens up in the woods as the trees pop and groan to bend around it.");
                        Console.WriteLine("The path is dark. There is no way to know where it leads but you have no other options.");
                        Console.WriteLine("You take a breath. Steady your courage and make for the path.");
                        third();
                        break;
                    }
             }
        }
        public static void first()
            {
                int Decision;
                    Console.WriteLine("A low growl can be heard amongst the trees");
                    Console.WriteLine("You head towards the noise, you see red eyes from within the woods.");
                    Console.WriteLine("Will you Run or Fight? Type 1 or 2.");
                    Console.Write("Decision: ");
                    
                int.TryParse(Console.ReadLine(), out Decision);
                int loop = 0;
                bool dead = false;

                while (Decision != 1 && dead == false)
                    {
                        if (loop <= 0)
                        {
                    Console.WriteLine("You are too slow, a large bear leaps out and claws you in the chest.");
                    Console.WriteLine("You are bleeding profusely now, will you Run or Fight?");
                    Console.Write("Decision: ");
                    int.TryParse(Console.ReadLine(), out Decision);
                    loop ++ ;
                        }
                else if (loop >= 1)
                            {
                    Console.WriteLine("The bear grabs you, and tosses you onto the ground.");
                    Console.WriteLine("Fear and adrenaline surge within you. Run or Fight? 1 or 2? ");
                    Console.Write("Decision: ");
                    int.TryParse(Console.ReadLine(), out Decision);
                    dead = true;
                            }
               
                    }
                if (dead == true )
                    {
                    Console.WriteLine("The bear lunges at you one last time");
                    Console.WriteLine("All you see is darkness, and then nothingness");
                    Console.ReadLine();
                    youDied();
                    }
                else 
                    {
                    Console.WriteLine("You swing your sword, cutting the bear in two.");
                    Console.WriteLine("You sprint past him and see a bright light ahead of you.");
                    Console.WriteLine("You run like crazy until you make it out of the woods.");
                    Console.ReadLine();
                    youWin();
                    }
            }
        
        public static void second()
            {
                int Decision;
                    Console.WriteLine("You hear something running, and quick towards you from the woods.");
                    Console.WriteLine("You manage, to catch a glimpse of what it is. A Minotaur runs past you, barley managing to miss you.");
                    Console.WriteLine("Will you Run or Fight? Type 1 or 2.");
                    Console.Write("Decision: ");
                    
                int.TryParse(Console.ReadLine(), out Decision);
                int loop = 0;
                bool dead = false;

                while (Decision != 1 && dead == false)
                    {
                        if (loop <= 0)
                        {
                    Console.WriteLine("You are too slow, to fire, the Minotaur pins you onto a tree with one of its horns.");
                    Console.WriteLine("You are bleeding profusely now, will you Run or Fight?");
                    Console.Write("Decision: ");
                    int.TryParse(Console.ReadLine(), out Decision);
                    loop ++ ;
                        }
                else if (loop >= 1)
                            {
                    Console.WriteLine("The Minotaur pulls back and gets ready to charge you again.");
                    Console.WriteLine("You ready your bow and take aim, do you  Run or Fight? 1 or 2? ");
                    Console.Write("Decision: ");
                    int.TryParse(Console.ReadLine(), out Decision);
                    dead = true;
                            }
               
                    }
                if (dead == true )
                    {
                    Console.WriteLine("The Minotaur charges at you, you take aim and fire, but the Minotaur just side steps it away and closes in on you.");
                    Console.WriteLine("All you hear is the tree snapping behind you, and then Nothingness");
                    Console.ReadLine();
                    youDied();
                    }
                else 
                    {
                    Console.WriteLine("You take aim faster then the Minotaur can get ready. You take aim.");
                    Console.WriteLine("You let go of the arrow and it zips towards the Minotaur with a easy head-shot, killing it instantly.");
                    Console.WriteLine("You run like crazy past the dead Minotaur until you see a bright light ahead.");
                    Console.ReadLine();
                    youWin();
                    }
            }

        public static void third()
            {
                int Decision;
                    Console.WriteLine("You hear a loud screeching noise coming from the woods.");
                    Console.WriteLine("You ready your wand, somehow knowing  which commands to use to activite it.");
                    Console.WriteLine("A dark wraith swooshes onto your view.");
                    Console.WriteLine("Will you fight or run? Type 1 or 2.");
                    Console.Write("Decision: ");
                    
                int.TryParse(Console.ReadLine(), out Decision);
                int loop = 0;
                bool dead = false;

                while (Decision != 1 && dead == false)
                    {
                        if (loop <= 0)
                        {
                    Console.WriteLine("You hear the wraith mumble something, so quite that you could barley make it out.");
                    Console.WriteLine("You feel a sharp pain coming from your abdomen, you are bleeding profusely, will you Run or Fight?");
                    Console.Write("Decision: ");
                    int.TryParse(Console.ReadLine(), out Decision);
                    loop ++ ;
                        }
                else if (loop >= 1)
                            {
                    Console.WriteLine("You feel a Invisable force pin you down, restricing your movement, only able to move your hand with the wand in it.");
                    Console.WriteLine("You are feeling scared and full of adrenaline. Fight or run? 1 or 2? ");
                    Console.Write("Decision: ");
                    int.TryParse(Console.ReadLine(), out Decision);
                    dead = true;
                            }
               
                    }
                if (dead == true )
                    {
                    Console.WriteLine("The wraith hovers above you calling a ritual knife above you.");
                    Console.WriteLine("The knife slowly pierces your skull, you start to black out from the pain.");
                    Console.ReadLine();
                    youDied();
                    }
                else 
                    {
                    Console.WriteLine("You yelled from the top of your lungs a foreign tongue that distintigrates the wraith with no trace.");
                    Console.WriteLine("You hurdly sprint past were the wraith was..");
                    Console.WriteLine("You run like crazy until you make it out of the woods.");
                    Console.ReadLine();
                    youWin();
                    }
            }
        
        public static void youDied()
            {
                Console.Clear();
                Console.WriteLine("You have failed");
                Console.WriteLine("The End.");
                Console.ReadLine();
                Console.Clear();
                forestAdventure();
            }

        public static void youWin()
            {
                Console.Clear();
                Console.WriteLine("You made it out!");
                Console.WriteLine("You see a familiar face and ask for help");
                Console.WriteLine("The End.");
                Console.ReadLine();
                Console.Clear();
                forestAdventure();
            } 

    }
}