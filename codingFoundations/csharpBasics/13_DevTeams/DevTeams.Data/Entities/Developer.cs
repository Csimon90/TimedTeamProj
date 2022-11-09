
//POCO => Plain Old C# Object

    public class Developer
    {
       public int Id {get; set;}
       public string FirstName {get; set;}
       public string LastName{get; set;}
       public string FullName
       {
            get
            {
                return $"{FirstName} {LastName}";
            }
       }
       public bool HasPluralsight {get; set;} 
    }
