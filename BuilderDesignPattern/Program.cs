// See https://aka.ms/new-console-template for more information

namespace BDP
/// Problem Statement: 
/// You are designing a meal ordering system where customers can build custom meal combos by selecting
/// a main dish, a side dish, a drink, and a dessert. The order should be created step by step,
/// allowing flexibility in customization.

#region MainStartupClass
{
    public static class Program
    {
        public static void Main(string[] args)
        { 
            MealBuilder mealBuilder = new MealBuilder();
            Meal meal = mealBuilder.SetMainDish("Pizza")
                .SetDish("Burger")
                .SetDesert("IceCream")
                .SetDrink("Coke")
                .Build();
            
            Console.WriteLine(meal.ToString());
        }
    }
}
#endregion

