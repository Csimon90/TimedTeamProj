//For loops 

//1.initializer
//2.condition
//3.iterator ++,--,+=,/=
    //1       //2   //3
for(int i=0; i<100; i++){
    System.Console.WriteLine(i);
}



//Challenge
//Prompt the user for a number to count to from zer
System.Console.WriteLine("Please give me a number");
//Take the input from zero to the number given by the user.
int userInput = int.Parse(Console.ReadLine());
//lopp all numbers from zero to the number given by the user.
for(int i=0; i<= userInput; i++){
    if(i % 2 ==0){
        System.Console.WriteLine(i);
    }
}