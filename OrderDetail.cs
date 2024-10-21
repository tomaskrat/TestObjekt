namespace Pizza;

public class OrderDetail
{
    public OrderDetail(Pizza pizza, int count = 1, string[] extras = null)
    {
        Pizza = pizza;
        Count = count;
        Pizza.Extras = extras;
    }

    public Pizza Pizza { get; set; }

    public int Count { get; set; }

    public override string ToString()
    {
        return $"{Pizza}: {Count}ks";
    }
}
