using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpException
{
    class TriangleException : Exception
    {
        public TriangleException(string message) : base(message)
        {
        }
    }

    class Triangle
    {
        private double sideOne;
        private double sideTwo;
        private double sideThree;

        public double SideOne
        {
            get { return sideOne; }
            set { sideOne = value; }
        }

        public double SideTwo
        {
            get { return sideTwo; }
            set { sideTwo = value; }
        }

        public double SideThree
        {
            get { return sideThree; }
            set { sideThree = value; }
        }

        public Triangle()
        {
            sideOne = 0;
            sideTwo = 0;
            sideThree = 0;
        }

        public Triangle(double sideOne, double sideTwo, double sideThree)
        {
            this.sideOne = sideOne;
            this.sideTwo = sideTwo;
            this.sideThree = sideThree;
        }

        public void ReadSidesFromUser()
        {
            bool validInput = false;

            while (!validInput)
            {
                try
                {
                    Console.Write("Enter side length 1: ");
                    sideOne = double.Parse(Console.ReadLine());

                    Console.Write("Enter side length 2: ");
                    sideTwo = double.Parse(Console.ReadLine());

                    Console.Write("Enter side length 3: ");
                    sideThree = double.Parse(Console.ReadLine());

                    ValidateTriangle();
                    validInput = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input format. Please enter a number.");
                }
                catch (TriangleException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void ValidateTriangle()
        {
            if (sideOne <= 0 || sideTwo <= 0 || sideThree <= 0)
            {
                throw new TriangleException("Triangle side length must be greater than zero.");
            }

            if (sideOne + sideTwo <= sideThree || sideTwo + sideThree <= sideOne || sideOne + sideThree <= sideTwo)
            {
                throw new TriangleException("Incorrect triangle side lengths. The sum of any two sides must be greater than the third side.");
            }
        }

        public void PrintTriangleDetails()
        {
            Console.WriteLine("Sides of a triangle:");
            Console.WriteLine($"Side 1: {sideOne}");
            Console.WriteLine($"Side 2: {sideTwo}");
            Console.WriteLine($"Side 3: {sideThree}");
        }
    }
}
