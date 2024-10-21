namespace Pizza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Osoba = new Osoba("Jan", "Novák"),
                Details = [
                    new OrderDetail (PizzaMenu.Margharita, 2, ["chilli"])
                    ]
            };
            
            Console.WriteLine (order);

            Console.ReadLine();
        }
    }
}
