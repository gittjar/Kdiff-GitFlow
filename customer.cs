public class Customer
{
    // Auto-implemented properties for trivial get and set
    public double TotalPurchases { get; set; }
    public string Name { get; set; }
    public int CustomerId { get; set; }

    // Constructor
    public Customer(double purchases, string name, int id)
    {
        TotalPurchases = purchases;
        Name = name;
        CustomerId = id;
    }

    // Methods
    public string GetContactInfo() { return "ContactInfo"; }
    public void GetTransactionHistory() 
    { 
        
        Console.WriteLine("ostoshistoriasi: " + Name);

        
        string[] items = {"LVI-putkia", "Kuutio tiiliä", "Teräsverkkoa", "Lankkua", "EPS-eristettä", "Patolevyä"};
        var totalElements = items.Count();
		totalElements = items.Count();
		Console.WriteLine("tuotteita: " + totalElements + " kappaletta!");
        Console.WriteLine("----");
        Array.ForEach(items, Console.WriteLine);
        Console.WriteLine("----");
    }

    // .. Additional methods, events, etc.
}