public class Horse
{
    private bool isCompetitionReady;
    private double speed;
    private string name;

    public bool IsCompetitionReady
    {
        get { return isCompetitionReady; }
    }

    public double Speed
    {
        get { return speed; }
        set { speed = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public static string Kind { get; set; } = "Horse";

    public static void ShowMessage()
    {
        Console.WriteLine("Hello from static method!");
    }
}