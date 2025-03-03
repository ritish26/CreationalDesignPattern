namespace BDP;

public class MealBuilder
{
    public string MainDish { get; set; }
    public string SideDish { get; set; }
    public string Dessert { get; set; }
    public string Drink { get; set; }
    
    
    public MealBuilder SetMainDish(string mainDish)
    {
        this.MainDish = mainDish;
        return this;
    }

    public MealBuilder SetDrink(string drink)
    {
        this.Drink = drink;
        return this;
    }

    public MealBuilder SetDish(string dish)
    {
        this.SideDish = dish;
        return this;
    }

    public MealBuilder SetDesert(string dessert)
    {
        this.Dessert = dessert;
        return this;
    }

    public Meal Build()
    {
        return new Meal(this);
    }
    
    
}