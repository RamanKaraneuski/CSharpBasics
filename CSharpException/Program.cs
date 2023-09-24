using System;

namespace CSharpException
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1-2
            Triangle triangle = new Triangle();
            triangle.ReadSidesFromUser();
            triangle.PrintTriangleDetails();
            #endregion


        }
    }
}
