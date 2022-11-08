//Conditionals

//Handle making decisions w/n an application

//Anytime we want an application to do work based on any condition.

//Ex: If user is logged in, redirect the user to the login page
//if it's the user birthday, tell them Happy Birthday
//If the user does not fit the necessary role, then deny them access.

bool isRaining = true;
bool isGoingOutside = false;

//if statements
//formula:
//Given a boolean, if the boolean evaluated to 'true' do the action you're given

//if(true/false value)
//{
    //body of the code, this will execute based on above boolean
//}

//Basically:
if(isRaining){
    System.Console.WriteLine("Its raining out!");
}

//Multiple if statements
if(isRaining)
 if(isGoingOutside)
    System.Console.WriteLine("Better bring out the umbrella!");

if(isRaining && isGoingOutside){
        System.Console.WriteLine("Better bring out the umbrella!");
    }

//if(isRaining)
  //  if(isGoingOutside)
    //    System.Console.WriteLine("Better bring out the umbrella!");

//OR
if(!isRaining || isGoingOutside ==false){
System.Console.WriteLine("I don't need a umbrela");
}

//XOR 
if(isRaining ^ isGoingOutside)
{
    System.Console.WriteLine("I will go outside if its not raining.");
}

//Challenge
//write an if statement that uses a new boolean called 'hasUmbrella' that will display text
bool hasUmbrella; //false
hasUmbrella = true;
isGoingOutside = true;
//to the Console if the user has an umbrella and is going outside while it's raining.
if(hasUmbrella && isGoingOutside  && isRaining)
{
    System.Console.WriteLine("Good thing I have my umbrella so I ca go outside while it's raining!");
}
//Example of expected output:
// Good thing I have my umbrella so I can go outside while it's raining!

