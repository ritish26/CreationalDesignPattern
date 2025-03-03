namespace BDP;

// This class represent Complete Meal
public class Meal
{
    public Meal(MealBuilder mealBuilder)
    {
        this.Dessert = mealBuilder.Dessert;
        this.MainDish = mealBuilder.MainDish;
        this.Drink = mealBuilder.Drink;
        this.SideDish = mealBuilder.SideDish;
    }

    public string MainDish { get; set; }
    public string SideDish { get; set; }
    public string Dessert { get; set; }
    public string Drink { get; set; }

    public override string ToString()
    {
        return $" MainDish: {MainDish}\n SideDish: {SideDish}\n Drink: {Drink}\n Dessert: {Dessert}";
    }
    
}