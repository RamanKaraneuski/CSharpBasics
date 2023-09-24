using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Pyramid : Shape
{
    private double _height;
    private double _baseArea;

    public Pyramid(string name, double height, double baseArea) : base(name)
    {
        _height = height;
        _baseArea = baseArea;
    }

    public override double CalculateVolume()
    {
        return (_baseArea * _height) / 3;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Height: {_height}");
        Console.WriteLine($"Base Area: {_baseArea}");
    }
}