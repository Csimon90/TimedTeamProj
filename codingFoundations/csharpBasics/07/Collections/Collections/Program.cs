using System.Collections.Generic;
using System;
//We Dont DO THIS ANYMORE!!!
object[] stuff = new object [5];
stuff[0] = "Terry";
stuff[1] = 1;
stuff[2] = 44.75f;
stuff[3] = "Bill Bob";

foreach(var item in stuff)
{
    Console.WriteLine(item);
}

//We need type safety
string stringExample = "Hello World!";

//Arrays are Fixed Values
//They always start at zero (zero indexed)
//We it comes to retriving data these are quick 
//But, when it comes to copying and moving data around this SUCKS

//Array of type string
string[] stringArray = 
{
    "Hello",
    "World",
    "why",
    "is it ",
    "Always",
    stringExample,
    "?",
};

System.Console.WriteLine(stringArray[3]); //is it

stringArray[1]= "Hey there";
System.Console.WriteLine(stringArray[1]);

//Arrays have a overall length, which tells us how many items there are
System.Console.WriteLine(stringArray.Length); //7

//List <T> -> t is the "Generic Type" that  the collection is composed of 
//T can be any 'type'

//List are arrays under the hood, but are more dynamic
//They have a max count, Ex: 10, and doubles when teh away is about to be filled.
//List <T> uses.Count instead of .Length

List<string> listOfStrings= new List<string>();

List<int> ListOfIntegers = new List<int>();

listOfStrings.Add("Tj");
listOfStrings.Add("James");
listOfStrings.Add("Jed");

ListOfIntegers.Add(4455);

System.Console.WriteLine(listOfStrings[0]);

foreach(var name in listOfStrings)
{
    Console.WriteLine(name);
}

listOfStrings.Remove(listOfStrings[listOfStrings.IndexOf("james")]);
System.Console.WriteLine("0--------------0");

foreach(var name in listOfStrings)
{
    Console.WriteLine(name);
}

//Queues<T>
//F.I.F.O -> First In, First Out
//line in general, who ever is first in line is serviced first 

Queue<string> firstInFirstOut = new Queue<string>();

//add to the queue
firstInFirstOut.Enqueue("I'm First.");
firstInFirstOut.Enqueue("I'm Second.");

//see who's next in line
string firstIn =firstInFirstOut.Peek();

System.Console.WriteLine(firstIn);

//to service the first one 
firstInFirstOut.Dequeue();

firstIn = firstInFirstOut.Peek();
System.Console.WriteLine(firstIn);

//Dictionary<TKey,Tvalue> (key/value) pair
//Can't have the same key
//When it comes to iterations we can constrain them

Dictionary<int,string> keyAndValue = new Dictionary<int, string>();
keyAndValue.Add(1,"Terry");
keyAndValue.Add(2,"Tj");
//no constraint here -> jey/value pair
foreach(KeyValuePair<int,string> values in keyAndValue)
{
    System.Console.WriteLine(values);
}

//constraints -> just show me Keys
System.Console.WriteLine("---------Keys--------");
foreach (int values in keyAndValue.Keys)
{
    System.Console.WriteLine(values);
}
//constraints -> just show me values....
System.Console.WriteLine("--------Values----------");
foreach (string values in keyAndValue.Values)
{
    System.Console.WriteLine(values);
}

string tj = keyAndValue[2];
System.Console.WriteLine(tj);

//Other Collections
SortedList<int,string> sortedKeyValuePair = new SortedList<int, string> ();
HashSet<int> uniqueList = new HashSet<int>();
Stack<string> lastInFirstOut = new Stack<string>();

//------------using Random-----

Random rng = new Random();

int number = rng.Next(5,7);
System.Console.WriteLine(number);