public static class HorseHelper
{
    public static void DisplayHorseInfo(Horse horse)
    {
        Console.WriteLine("Horse Name: " + horse.Name);
        Console.WriteLine("Horse Speed: " + horse.Speed);
        Console.WriteLine("Horse IsCompetitionReady: " + horse.IsCompetitionReady);
    }

    public static void DisplayHorseInfoWithColor(Horse horse, string color)
    {
        Console.WriteLine("Horse Name: " + horse.Name);
        Console.WriteLine("Horse Speed: " + horse.Speed);
        Console.WriteLine("Horse IsCompetitionReady: " + horse.IsCompetitionReady);
        Console.WriteLine("Horse Color: " + color);
    }
    public static void PrintHorseData(Horse horse)
    {
        Console.WriteLine("Horse Data:");
        Console.WriteLine("IsCompetitionReady: " + horse.IsCompetitionReady);
        Console.WriteLine("Speed: " + horse.Speed);
    }
    public static void PrintHorseSpeed(Horse horse)
    {
        Console.WriteLine("Horse Speed: " + horse.Speed);
    }
}
