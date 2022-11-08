//Foreach syntax
//foreach (declaredIterator in enumerableCollection)
//{
    //body
//}

//Ex:

string intstructorName = "Amanda";

//we need to make a collection
string [] instructors = new string []{
    "Micheal","Joshua",intstructorName
};

foreach(string instructor in instructors){
System.Console.WriteLine(instructor);
}

int[] intArray = new int []
{
    1,
    2,
    -3,
    4,
    5,
    0
};

//manual wat
/* int[] myArray = new int [3];
myArray [0]=300;
myArray [0]=30; */

/* foreach (int number in intArray)
{
    if(number <0)
    System.Console.WriteLine("this is a negative number.");
    else if(number>0)
    System.Console.WriteLine("This is a positive number.");
    else
    System.Console.WriteLine("This is a neutral number.");
 */
    switch(number)
    {
        case 0:
        case 1:
        case 2:
        case 4:
        case 5:
        System.Console.WriteLine("this is a negative number.");
        break;
        case -3:
        System.Console.WriteLine("This is a positive number.");
        break;
        default:
        System.Console.WriteLine("This is a neutral number.");
        break;
    }
