//what if the if statement didn't work?
// what else can we do?

//Ex: 
bool isRaining = true;

if(!isRaining){
    System.Console.WriteLine("I'll cut the grass.");
}
else{
    System.Console.WriteLine("I guess I can't cut the grass");
}

//another example
bool isGoingOutside = true;

if(isGoingOutside){
    System.Console.WriteLine("Make sure to dress for the weather .");
}
else{
    System.Console.WriteLine("Sounds like a sweater kind of day");
}

// another one:
if(isGoingOutside){
    System.Console.WriteLine("Make sure to dress for the weather.");
}
else if(isRaining){
//..code
}
else{
    System.Console.WriteLine("Sounds like a sweater kind of day");
}

//else is "If all else fails" or "default"

//we want to ask the user, how are you feeling today?
System.Console.WriteLine("How are you feeling? (1-5)");

//we want to store the users input with in a 'string' container
string userInput = Console.ReadLine();

if(userInput == "1"){
    System.Console.WriteLine("I hope your day gets better.");
}
else if(userInput =="2"){
    System.Console.WriteLine("Oh, sorry to hear that.");
}
else if(userInput == "3"){
    System.Console.WriteLine("Hope things Improve");
}
else if(userInput == "4"){
    System.Console.WriteLine("Good stuff!");
}
else if(userInput == "5"){
    System.Console.WriteLine("Wow that is great to hear!");
}
else{
    System.Console.WriteLine("Invalid Key Entry.");
}

string userInput = Console.WriteLine();

switch (userInput)
{
    case "1":
            System.Console.WriteLine("I hope your day gets better.");
    break;
    case "2":
        System.Console.WriteLine("Oh, sorry to hear that.");
    break;
    case "3":
        System.Console.WriteLine("Hope things Improve");
    break;
    case "4":
         System.Console.WriteLine("Good stuff!");
    break;
    case "5":
         System.Console.WriteLine("Wow that is great to hear!");
    break;
     default:
        System.Console.WriteLine("Invalid Key Entry.");
    break;
}

//Challenge
//Creating a switch statement
//want to output discriptions for a few of your friends
//Prompt the user's input to enter a friends name
//Take in a user's input from the Console
//If the input is one of the listed friends write a fact about that person to the Console

//Extra Challenge:
    // what can you do with cases like "Paul" and "paul" as these are different values