using System.Collections.Generic;
using Xunit;

namespace InterfaceTests;

public class UnitTest1
{
    [Fact]
    public void Calling_Interface_Methods()
    {
        //declare a new interface instance
        //its Type will be IFruit
        //We cannot new-up Interfaces
        //but we can make a new Banana

        IFruit banana = new Banana();

        string output = banana.Peel();
        System.Console.WriteLine(output);

        System.Console.WriteLine("The Banana is peeled: "+ banana.isPeeled);

        Assert.True(banana.isPeeled);

    }
    [Fact]
    public void Interface_Collections()
    {
        //start with orange object
        //its not going to be an IFruit

        Orange orange = new Orange();

        //lets make a list
        List<IFruit> fruits = new List<IFruit>
        {
            new Banana(),
            new Grape(),
            orange

        };

        //loop through this list 
        foreach (IFruit fruit in fruits)
        {
            System.Console.WriteLine(fruit.Name);
            System.Console.WriteLine(fruit.Peel());
            
            Assert.IsType(typeof(IFruit), fruit);
        }

        System.Console.WriteLine(orange.Squeeze());

        Assert.IsType(typeof(Orange),orange);
    }
}