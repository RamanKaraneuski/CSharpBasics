namespace CSharpOOP
{
    class Homework_1
    {
        static void Main(string[] args)
        {
            #region Task_1
            CalculateTotalAmount();
            #endregion

            #region Task_2
            GenerateReceipt();
            #endregion

            #region Task_3
            GenerateReceipt(2);  //  Вызов метода с необязательным параметром
            GenerateReceipt();   //  Вызов метода без указания количества предметов
            #endregion

            #region Task_4
            CalculatePerimeter(3, 4, 5);        // Периметр треугольника
            CalculatePerimeter(4, 5, 6, 7);     // Периметр четырехугольника
            CalculatePerimeter(5, 6, 7, 8, 9);  // Периметр пятиугольника
            #endregion

            #region Task_5
            CalculateAreas();
            #endregion

        }

        static void CalculateTotalAmount()
        {
            Console.WriteLine("Enter the number of items:");
            int quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter unit price:");
            double pricePerUnit = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter discount:");
            double discount = Convert.ToDouble(Console.ReadLine());

            double totalAmount = quantity * pricePerUnit * (1 - discount / 100);

            Console.WriteLine("Total amount: " + totalAmount);
        }

        static void GenerateReceipt(int itemCount = 1)
        {
            string[] itemNames = new string[itemCount];
            int[] itemQuantities = new int[itemCount];
            double[] itemPrices = new double[itemCount];

            for (int i = 0; i < itemCount; i++)
            {
                Console.WriteLine($"Enter item name {i + 1}:");
                itemNames[i] = Console.ReadLine();

                Console.WriteLine($"Enter item quantity {itemNames[i]}:");
                itemQuantities[i] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Enter price per item {itemNames[i]}:");
                itemPrices[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Enter total discount:");
            double discount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("-------- Check --------");
            for (int i = 0; i < itemCount; i++)
            {
                double totalAmount = CalculateTotalAmount(itemQuantities[i], itemPrices[i], discount);

                Console.WriteLine($"Item name: {itemNames[i]}");
                Console.WriteLine($"Quantity: {itemQuantities[i]}");
                Console.WriteLine($"Unit price: {itemPrices[i]}");
                Console.WriteLine($"Total amount: {totalAmount}");
                Console.WriteLine("---------------------");
            }
        }

        static double CalculateTotalAmount(int quantity, double pricePerUnit, double discount)
        {
            return quantity * pricePerUnit * (1 - discount / 100);
        }

        static void CalculatePerimeter(params double[] sides)
        {
            double perimeter = 0;
            foreach (double side in sides)
            {
                perimeter += side;
            }
            Console.WriteLine("Perimeter: " + perimeter);
        }

        static void CalculateAreas()
        {
            double triangleArea = CalculateArea(5, 6, 7); // Площадь треугольника с вводом данных
            Console.WriteLine("Area of ​​a triangle: " + triangleArea);

            double circleArea = CalculateArea(3.5);      // Площадь круга с явным указанием значения
            Console.WriteLine("Area of ​​a circle: " + circleArea);
        }

        static double CalculateArea(double side1, double side2, double side3)
        {
            double semiPerimeter = (side1 + side2 + side3) / 2;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - side1) * (semiPerimeter - side2) * (semiPerimeter - side3));
            return area;
        }

        static double CalculateArea(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }

        /*
        Класс Фигура:
        - Свойство: Площадь
        - Свойство: Периметр
        - Метод: Рассчитать площадь
        - Метод: Рассчитать периметр

        Класс Прямоугольник наследует класс Фигура:
        - Свойство: Ширина
        - Метод: Рассчитать площадь (переопределение метода из класса Фигура)

        Класс Автомобиль:
        - Закрытое поле: Скорость
        - Метод: УстановитьСкорость
        - Метод: ПолучитьСкорость

        Класс Фигура:
        - Метод: ВычислитьПлощадь (виртуальный метод)

        Класс Круг наследует класс Фигура:
        - Метод: Вычислить

         Class Figure:
         - Property: Area
         - Property: Perimeter
         - Method: Calculate area
         - Method: Calculate perimeter

        The Rectangle class inherits the Shape class:
        - Property: Width
        - Method: Calculate area (overriding the method from the Shape class)

        Car class:
        - Closed field: Speed
        - Method: SetSpeed
        - Method: GetSpeed
        
        Class Figure:
        - Method: Calculate Area (virtual method)

        The Circle class inherits the Shape class:
        - Method: Calculate
        */

    }
}