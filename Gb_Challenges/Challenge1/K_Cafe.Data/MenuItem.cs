
    public class MenuItem
    {
        // Properties
        public int mealNumber { get; set; }
        public string mealName { get; set; }

        public string mealDescription { get; set; }

        public string mealIngredients { get; set; }
        public decimal mealPrice { get; set; }

        public MenuItem()
        {
            
        }
        public MenuItem( string Name, string Description, string Ingredients, decimal Price)
        {
            mealName = Name;
            mealDescription = Description;
            mealIngredients = Ingredients;
            mealPrice = Price;
        }
        public override string ToString()
        {
            string str = $"Meal Number: {mealNumber}\n"+
            $"Meal Name: {mealName}\n"+
            $"Meal Description: {mealDescription}\n"+
            $"Meal Ingredients: {mealIngredients}\n"+
            $"Meal Price: {mealPrice}\n"+
            "-------------------------------------------------------------\n"; 


            return str;
        }
    }
    
