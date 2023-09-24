namespace CSharpAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
        }

        #region Task1

        static void Task1()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            int firstNumber = GenericHelper.GetFirstItem(numbers);
            Console.WriteLine("First element of a list of numbers: " + firstNumber);

            List<string> names = new List<string> { "Roman", "Alex", "Maksim" };
            string firstName = GenericHelper.GetFirstItem(names);
            Console.WriteLine("First element of the list of names: " + firstName);
        }

        #endregion

        #region Task2

        static void Task2()
        {
            Rose rose = new Rose { Name = "Rose", Color = "Red", Price = 1.5 };
            Chamomile chamomile = new Chamomile { Name = "Chamomile", Color = "White", Price = 0.8 };

            GenericHelper.ReadFlowerCount(rose);
            GenericHelper.ReadFlowerCount(chamomile);

            GenericHelper.PrintReceipt(rose);
            GenericHelper.PrintReceipt(chamomile);
        }

        #endregion

        #region Task3

        static void Task3()
        {
            Rose rose = new Rose { Name = "Rose", Color = "Red", Price = 1.5 };
            Chamomile chamomile = new Chamomile { Name = "Chamomile", Color = "White", Price = 0.8 };

            GenericHelper.ReadFlowerCount(rose);
            GenericHelper.ReadFlowerCount(chamomile);

            GenericHelper.PrintReceipt(rose);
            GenericHelper.PrintReceipt(chamomile);

            FlowerUpgrader<Rose> roseUpgrader = new FlowerUpgrader<Rose>(rose);
            roseUpgrader.Upgrade();

            FlowerUpgrader<Chamomile> chamomileUpgrader = new FlowerUpgrader<Chamomile>(chamomile);
            chamomileUpgrader.Upgrade();

            GenericHelper.PrintReceipt(rose);
            GenericHelper.PrintReceipt(chamomile);
        }

        #endregion

        #region Task4

        static void Task4()
        {
            int[,] matrix1 = MatrixHelper.CreateMatrix(3, 3);
            int[,] matrix2 = MatrixHelper.CreateMatrix(3, 3);

            Console.WriteLine("Matrix 1:");
            MatrixHelper.PrintMatrix(matrix1);

            Console.WriteLine("Matrix 2:");
            MatrixHelper.PrintMatrix(matrix2);

            int[,] sumMatrix = MatrixHelper.AddMatrices(matrix1, matrix2);
            Console.WriteLine("Sum of matrices:");
            MatrixHelper.PrintMatrix(sumMatrix);

            int[,] productMatrix = MatrixHelper.MultiplyMatrices(matrix1, matrix2);
            Console.WriteLine("Product of matrices:");
            MatrixHelper.PrintMatrix(productMatrix);
        }

        #endregion
    }

}