//Switch
//'switch' keyword
//like if statements, but does away with "branching"

//1. value thats going to be evaluated

//2. "value" will be checked w//n the switch statement by a "case"

//3. "break" to indicate that we want to leave the switch statement

//4. "default" -> if all else fails

//Ex: 
//value to be evaluated:
string name = Console.ReadLine("Please input your name ...");

//todo: we are going to switch on of this 'name' value.
switch(name){
    //this is the value passed in which is being "checked" by case
    case "Pete":
    case "pete":
        System.Console.WriteLine("Hi, Pete!");

    break; //we have to leave the switch statement to prevent 'falling-through'

    //so, if the user types any other name then:
    default:
    System.Console.WriteLine("Invalid Option (Name).");
    break;
}