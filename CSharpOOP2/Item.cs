class Item
{
    public string Name { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }

    // Конструктор инициализирующий все поля
    public Item(string name, int quantity, decimal price)
    {
        Name = name;
        Quantity = quantity;
        Price = price;
    }

    // Пустой конструктор
    public Item()
    {
        
        Name = "";
        Quantity = 0;
        Price = 0;
    }

    // Конструктор инициализирующий 1-2 поля
    public Item(string name)
    {
        Name = name;
        Quantity = 0; 
        Price = 0;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Item Details:");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Quantity: " + Quantity);
        Console.WriteLine("Price: " + Price);
        Console.WriteLine();
    }
}