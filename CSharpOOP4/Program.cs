namespace CSharpOOP4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Shape
            Shape shape = new Ball("Ball", 4);
            shape.DisplayInfo();
            Console.WriteLine();
            #endregion

            #region Ball
            Ball ball = new Ball("Ball", 5);
            ball.DisplayInfo();
            Console.WriteLine();
            #endregion

            #region Pyramid
            Pyramid pyramid = new Pyramid("Pyramid", 8, 20);
            pyramid.DisplayInfo();
            Console.WriteLine();
            #endregion

            #region Cylinder
            Cylinder cylinder = new Cylinder("Cylinder", 10, 4);
            cylinder.DisplayInfo();
            Console.WriteLine();
            #endregion

            Console.ReadLine();


        }
    }
}