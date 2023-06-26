using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Cylinder : Shape
{
    private double _height;
    private double _radius;

    public Cylinder(string name, double height, double radius) : base(name)
    {
        _height = height;
        _radius = radius;
    }

    public override double CalculateVolume()
    {
        return Math.PI * Math.Pow(_radius, 2) * _height;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Height: {_height}");
        Console.WriteLine($"Radius: {_radius}");
    }
}