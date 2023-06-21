public class Item
{
    public string Name { get; set; }
    public string Code { get; set; }
    public double Price { get; set; }

    public Item()
    {
    }

    public Item(string name)
    {
        Name = name;
    }

    public Item(string name, string code, double price)
    {
        Name = name;
        Code = code;
        Price = price;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Code: {Code}");
        Console.WriteLine($"Price: {Price}");
        Console.WriteLine();
    }
}
