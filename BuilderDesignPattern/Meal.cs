namespace BDP;

// This class represent Complete Meal
public class Meal
{
    public Meal(MealBuilder mealBuilder)
    {
        Dessert = mealBuilder.Dessert;
        MainDish = mealBuilder.MainDish;
        Drink = mealBuilder.Drink;
        SideDish = mealBuilder.SideDish;
    }
    private string? MainDish { get; set; }
    private string? SideDish { get; set; }
    private string? Dessert { get; set; }
    private string? Drink { get; set; }

    public override string ToString()
    {
        return $" MainDish: {MainDish}\n SideDish: {SideDish}\n Drink: {Drink}\n Dessert: {Dessert}";
    }
    
}