using System;
using System.Collections.Generic;

public static class GenericHelper
{
    public static T GetFirstItem<T>(List<T> items)
    {
        if (items == null || items.Count == 0)
        {
            throw new ArgumentException("List of elements is empty.");
        }

        return items[0];
    }

    public static void ReadFlowerCount<T>(T flower) where T : Flower
    {
        Console.Write($"Enter Quantity {flower.Name}: ");
        int count = int.Parse(Console.ReadLine());
        flower.Count = count;
    }

    public static double CalculateBouquetCost<T>(T flower) where T : Flower
    {
        return flower.Price * flower.Count;
    }

    public static void PrintReceipt<T>(T flower) where T : Flower
    {
        double cost = CalculateBouquetCost(flower);
        Console.WriteLine("Check:");
        Console.WriteLine($"Flower: {flower.Name}");
        Console.WriteLine($"Color: {flower.Color}");
        Console.WriteLine($"Quantity: {flower.Count}");
        Console.WriteLine($"Price: {cost}");
    }
}
