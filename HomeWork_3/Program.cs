namespace HomeWork_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CheckNumberMethod_1();
            CheckNumberMethod_2();
            CheckNumberMethod_3();
        }
        static void CheckNumberMethod_1()
        {

            Console.Write("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0 && number % 5 == 0)
            {
                Console.WriteLine("tutti-frutti");
            }
            else if (number % 2 == 0)
            {
                Console.WriteLine("tutti");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("frutti");
            }

            Console.WriteLine("\nPress Enter to continue\n");
            Console.ReadLine();

        }

        static void CheckNumberMethod_2()
        {
            Console.Write("Enter the first number: ");
            int numberOne = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number (greater than the first): ");
            int numberTwo = Convert.ToInt32(Console.ReadLine());

            if (numberOne >= numberTwo)
            {
                Console.WriteLine("Error! The first number must be less than the second.");
                return;
            }

            PrintNumbersInRange(numberOne, numberTwo);

            Console.WriteLine("\nPress Enter to continue\n");
            Console.ReadLine();
        }

        static void CheckNumberMethod_3()
        {
            Console.Write("Enter the first number: ");
            int numberOne = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int numberTwo = Convert.ToInt32(Console.ReadLine());

            PrintNumbersInRange(numberOne, numberTwo);
        }

        static void PrintNumbersInRange(int start, int end)
        {
            int minNumber = Math.Min(start, end);
            int maxNumber = Math.Max(start, end);

            for (int i = minNumber; i <= maxNumber; i++)
            {
                if (i % 2 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Tutti-Frutti");
                }
                else if (i % 2 == 0)
                {
                    Console.WriteLine("Tutti");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Frutti");
                }
                else
                {
                    Console.WriteLine($"Number {i} can’t be divided on 2 or 5");
                }
            }
        }

    }
}