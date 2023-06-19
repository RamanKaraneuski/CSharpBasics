public class Chair
{
    public string Material { get; set; }
    public string Color { get; set; }
    public int LegsCount { get; set; }

    public void SitOn()
    {
        Console.WriteLine("You are sitting on the chair.");
    }

    public void Move()
    {
        Console.WriteLine("The chair is being moved.");
    }
}