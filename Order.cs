namespace Pizza;

public class Order
{
    public Osoba Osoba { get; set; }

    public OrderDetail[] Details { get; set; }

    public override string ToString()
    {
        string s = $"Objednavka pro {Osoba}";


        int n = 1;
        foreach (OrderDetail detail in Details)
        {
            s = s + $"\r\n {n}) {detail}";
            n++;
        }
        return s;
    }
}
