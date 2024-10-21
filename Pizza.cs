namespace Pizza;
public class Pizza
{
    public string Name { get; set; }

    public string[] Slozeni { get; set; }

    public string[] Extras { get; set; }

    public PizzaSizes Size { get; set; }

    public static Pizza Margharita => new Pizza
    {
        Name = "Margarita",
        Slozeni = ["sugo", "šunka", "syr"]
    };
    public override string ToString()
    {
        return $"{Name} {Size}";
    }
}

public enum PizzaSizes
{
    Size28,
    Size32
}
