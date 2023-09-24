using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Ball : Shape
{
    private double _radius;

    public Ball(string name, double radius) : base(name)
    {
        _radius = radius;
    }

    public override double CalculateVolume()
    {
        return (4 / 3) * Math.PI * Math.Pow(_radius, 3);
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Radius: {_radius}");
    }
}