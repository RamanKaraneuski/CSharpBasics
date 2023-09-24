using System;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;

namespace CSharpBasics
{
    /*class Homework_1
    {
        static void Main(string[] args)
        {
            new Homework_1().Task_1();
            new Homework_1().Task_2();
            new Homework_1().Task_3();
            new Homework_1().Task_4();
            new Homework_1().Task_5();
            new Homework_1().Task_6();
            new Homework_1().Task_7();
        }

        public void Task_1()
        {


     
            //Первый вариант


            //Первый вариант


            int a = 5;
            double b = 5.56;
            char c = 'c';
            bool d = false;
            string e = "Hello";
            Console.WriteLine($"5 Переменных различныйх типов: \n" + $"Целочисленный: {a} \n" + $"Значения с точкой: {b} \n" + $"Символьный: {c}  \n" + $"Логический: {d}  \n" + $"Ссылочный: {e}  \n");

            //Второй вариант Вывода

            Console.WriteLine("5 Переменных различныйх типов:");
            Console.WriteLine("int: " + a);
            Console.WriteLine("double: " + b);
            Console.WriteLine("char: " + c);
            Console.WriteLine("bool: " + d);
            Console.WriteLine("string: " + e);

            Console.WriteLine("\n Нажмите Enter чтобы продолжить \n");
            Console.ReadLine();
        }

        public void Task_2()
        {
            Первый вариант
            Console.WriteLine("Введите имя:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Введите фамилию:");
            string lastName = Console.ReadLine();

            int age;
            Console.WriteLine("Введите Возраст");
            string ageInput = Console.ReadLine();


            if (int.TryParse(ageInput, out age))
            {
                Console.WriteLine($"\"How old are you?\", - policemen asked.");
                Console.WriteLine($"\"{age}\", - {lastName} {firstName} answered.\n");
            }
            else
            {
                Console.WriteLine("Возраст должен быть числом.");
            }


            Console.WriteLine("\n Нажмите Enter чтобы продолжить \n");
            Console.ReadLine();

            Второй вариант
            Console.WriteLine("Введите имя, фамилию и возраст через пробел:");
            string input = Console.ReadLine();
            string[] inputParts = input.Split(' ');

            Trim() Удаляет символы пробелы из начала и конца строки
            string firstName1 = inputParts[0].Trim();
            string lastName1 = inputParts[1].Trim();
            var age1 = inputParts[2].Trim();
            int age = int.TryParse(inputParts[2].Trim(), out int parsedAge) ? parsedAge : 0;

            Console.WriteLine("\"Сколько вам лет?\", - спросил полицейский.");
            Console.WriteLine("\"{0}\", - {1} {2} ответил.\n", age1, firstName1, lastName1);


        }

        public void Task_3()
        {
            Первый вариант решения

            Console.WriteLine("Введите 3-4 слова через Enter:");

            string word1 = Console.ReadLine();
            string word2 = Console.ReadLine();
            string word3 = Console.ReadLine();
            string word4 = Console.ReadLine();

             .Join("") Если так то слова слипнуться, а ессли .Join("") то добавится пробел.По ТЗ вроде не нада пробел
            Console.WriteLine("\n" + string.Join("", $" Результат командой Join   ", word1, word2, word3, word4));

            Console.WriteLine(string.Concat($" Результат командой Concat ", word1, word2, word3, word4));

            Console.WriteLine("\n Нажмите Enter чтобы продолжить \n");
            Console.ReadLine();


            Второй вариант решения

            Console.WriteLine("Введите 3-4 слова через пробел:");

            string input = Console.ReadLine();
            string[] words = input.Split(' ');

            Console.WriteLine($"\n Результат командой Join   " + string.Join("", words));

            Console.WriteLine($" Результат командой Concat " + string.Concat(words));

            Console.WriteLine("\n Нажмите Enter чтобы продолжить \n");
            Console.ReadLine();

            Третий вариант решения

            Console.WriteLine("Введите 3-4 слова через пробел:");
            string Input = Console.ReadLine();

            string[] Words = Input.Split(' ');

            string joinWords = string.Join("", Words);
            Console.WriteLine($"\n Результат командой Join   {joinWords}");

            string concatWords = string.Concat(Words);
            Console.WriteLine($" Результат командой Concat {concatWords}");

            Console.WriteLine("\n Нажмите Enter чтобы продолжить \n");
            Console.ReadLine();

        }
        public void Task_4()
        {
            Console.WriteLine("Введите строку:\n");
            string inputWords = Console.ReadLine();

            string substring1 = inputWords.Substring(2);
            string substring2 = inputWords.Substring(0, 3);

            string[] substrings = { substring1, substrin2 };
            Console.WriteLine("Результат командой Join:");
            Console.WriteLine(string.Join(" --→ ", substring1, substring2));

            Console.WriteLine("\n Нажмите Enter чтобы продолжить \n");
            Console.ReadLine();
        }

        public void Task_5()
        {
            Console.WriteLine("Введите строку: He drove his black car down the road ");
            string poemList = Console.ReadLine();

            Console.WriteLine("Введите прилагательное противоположного значения (например white):");
            string antiAdjective = Console.ReadLine();

            Console.WriteLine("Результат замены:");
            Console.WriteLine(poemList.Replace("black", antiAdjective));

            Console.WriteLine("\n Нажмите Enter чтобы продолжить \n");
            Console.ReadLine();
        }

        public void Task_6()
        {
            Первый вариантан

            Console.WriteLine("Введите букву в нижнем регистре:");

            char loweLetter = Console.ReadLine()[0];
            char uppeLetter = char.ToUpper(loweLetter);

            Console.WriteLine($"Результат: {uppeLetter}\n");

            Второйервый вариантан

            Console.WriteLine("Введите букву в нижнем регистре:");

            string loweLetter1 = Console.ReadLine();
            string uppeLetter1 = loweLetter1.ToUpper();

            Console.WriteLine($"Результат: {uppeLetter1}\n");

            Console.WriteLine("Введите букву в нижнем регистре:");
            string LC = Console.ReadLine();
            string UP = LC.ToUpper();
            Console.WriteLine("Результат: " + UP);

            Console.WriteLine("\n Нажмите Enter чтобы продолжить \n");
            Console.ReadLine();
        }


        public void Task_7()
        {
            Console.WriteLine("Введите 3-4 строки через Enter:");
            string line1 = Console.ReadLine();
            string line2 = Console.ReadLine();
            string line3 = Console.ReadLine();
            string line4 = Console.ReadLine();

            StringBuilder strbil = new StringBuilder();

            strbil.Append(line1);
            strbil.Append(line2);
            strbil.Append(line3);
            strbil.Append(line4);

            string result = strbil.ToString();

            Console.WriteLine("Результат объединения:\n");
            Console.WriteLine(result);
        }

    }
    */

    class Homework_2
    {
        static void Main(string[] args)
        {
            new Homework_2().Task_1();
            new Homework_2().Task_2();
            new Homework_2().Task_3();
            new Homework_2().Task_4();
            new Homework_2().Task_5();
            new Homework_2().Task_6();
            new Homework_2().Task_7();
            new Homework_2().Task_8();
            new Homework_2().Task_9();
        }

        public void Task_1()
        {
            int number;
            bool isTrue;
            char character;
            double decimalNumber;

            Console.WriteLine("Enter an integer: \n");
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter the value of the boolean variable (true or false): \n");
            isTrue = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("\nEnter character: \n");
            character = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("\nEnter a floating point number: \n");
            decimalNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nEntered values:");
            Console.WriteLine("Integer: " + number);
            Console.WriteLine("Boolean: " + isTrue);
            Console.WriteLine("Character: " + character);
            Console.WriteLine("Float: " + decimalNumber);

            Console.WriteLine("\nPress Enter to continue\n");
            Console.ReadLine();
        }

        public void Task_2()
        {
            Console.WriteLine("Enter an integer: \n");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter a floating point number: \n");
            double decimalNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("\nEntered values:\n");
            Console.WriteLine("Integer: " + number);
            Console.WriteLine("Float: " + decimalNumber);

            Console.WriteLine("\nPress Enter to continue\n");
            Console.ReadLine();
        }

        public void Task_3()
        {
            int number;

            Console.WriteLine("Enter an integer: \n");
            string input = Console.ReadLine();

            bool success = int.TryParse(input, out number);

            if (success)
            {
                Console.WriteLine("\nThe operation is successful. Entered number: " + number);
            }
            else
            {
                Console.WriteLine("\nOperation failed. Invalid number format.");
            }

            Console.WriteLine("\nPress Enter to continue\n");
            Console.ReadLine();

        }

        public void Task_4()
        {
            int firstnumber, secondnumber, thirdnumber;

            firstnumber = 10;
            secondnumber = firstnumber + 3;
            thirdnumber = secondnumber + firstnumber;

            Console.WriteLine($" firstnumber = {firstnumber} \n secondnumber = {secondnumber} \n thirdnumber {thirdnumber}");

            Console.WriteLine("\nPress Enter to continue\n");
            Console.ReadLine();

        }

        public void Task_5()
        {
            int SSD, GPU, RAM, CPU, PowerSupplies, Motherboard;
            double priceSSD, priceGPU, priceRAM, priceCPU, pricePowerSupplies, priceMotherboard;

            SSD = 2;
            priceSSD = 300;

            GPU = 1;
            priceGPU = 2500;

            RAM = 4;
            priceRAM = 200;

            CPU = 1;
            priceCPU = 950;

            PowerSupplies = 1;
            pricePowerSupplies = 300;

            Motherboard = 1;
            priceMotherboard = 400;

            double totalCost = (SSD * priceSSD) + (GPU * priceGPU) + (RAM * priceRAM) + (CPU * priceCPU) + (PowerSupplies * pricePowerSupplies) + (Motherboard * priceMotherboard);
            double discount = totalCost * 0.15;
            double finalprice = totalCost - discount;

            Console.WriteLine("Shopping List:");
            Console.WriteLine($"SSD: {SSD} pcs. x {priceSSD} $.");
            Console.WriteLine($"GPU: {GPU} pcs. x {priceGPU} $.");
            Console.WriteLine($"RAM: {RAM} pcs. x {priceRAM} $.");
            Console.WriteLine($"CPU: {CPU} pcs. x {priceCPU} $.");
            Console.WriteLine($"PowerSupplies: {PowerSupplies} pcs. x {pricePowerSupplies} $.");
            Console.WriteLine($"Motherboard: {Motherboard} pcs. x {priceMotherboard} $.");
            Console.WriteLine("------------------------");
            Console.WriteLine($"Total: {totalCost} $.");
            Console.WriteLine($"Discount: {discount} $.");
            Console.WriteLine($"Total amount due: {finalprice} $.");

            Console.WriteLine("\nPress Enter to continue\n");

            Console.ReadLine();

            Console.ReadLine(); 

        }

        public void Task_6()
        {
            double a = 5;
            double b = 7;

            double c = (a++ + b / 2) + (a * b - a) / (a);

            // (a++ + b / 2)
            // b/2 = 7/2 = 3.5
            // a+b/2 = 5+3.5 = 8.5 

            // (a * b - a) / (a)
            // (5 * 7 - 5) / (5) = 6
            // 8.5 + 6 = 14.5

            // (a++ + b / 2)
            // 1) a++ = 5 , first use the value, then increase by 1
            // 2) b / 2 = 7 / 2 = 3.5
            // 3) a + b / 2 = 5 + 3.5 = 8.5

            // (a * b - a) / a
            // 1) a * b = 5 * 7 = 35
            // 2) (5 * 7 - 5) / (5) = (35 - 5) / 5 = 6
            // 3) 8.5 + 6 = 14.5

            a = 5;

            double d = (++a + b * b) / (a - b);

            // (++a + b * b)
            // 1) ++a = 5 + 1 = 6  
            // 2) b * b = 7 * 7 = 49
            // 3) ++a + b * b = 6 + 49 = 55

            // (a - b)
            // 1) a - b = 6 - 7 = -1

            // (a - b) != 0, so division by (a - b) is valid

            // (a + b * b) / (a - b)
            // 1) (a + b * b) = 55
            // 2) (a - b) = -1
            // 3) (a + b * b) / (a - b) = 55 / -1 = -55

            Console.WriteLine(c);
            Console.WriteLine(d);

            Console.WriteLine("\nPress Enter to continue\n");
            Console.ReadLine();
        }

        public void Task_7()
        {
            int a = 5;
            int b = 3;
            int c = 7;

            Console.WriteLine("a == b"); // a == b
            Console.WriteLine(a == b);  //  False
            Console.WriteLine(a != b); //   True

            Console.WriteLine("\na && b == c");      // a && b == c
            Console.WriteLine(a > b && b == c);     //  False
            Console.WriteLine(!(a > b && b == c)); //   True

            Console.WriteLine("\na || b != c");       // a || b != c
            Console.WriteLine(a == b || b != c);     //  True
            Console.WriteLine(!(a == b || b != c)); //   False

            Console.WriteLine("\na != b"); // a != b
            Console.WriteLine(a != b);         //  True
            Console.WriteLine(!(a != b));     //   False

            Console.WriteLine("\na <= b"); // a <= b
            Console.WriteLine(a <= b);         //  False
            Console.WriteLine(!(a <= b));     //   True

            Console.WriteLine("\nPress Enter to continue\n");
            Console.ReadLine();

        }

        public void Task_8()
        {
            byte value = 42;

            // boxing
            int boxedValue = value;

            // unboxing
            byte unboxedValue = (byte)boxedValue;

            Console.WriteLine("Исходное значение:      " + value);
            Console.WriteLine("Упакованное значение  : " + boxedValue);
            Console.WriteLine("Распакованное значение: " + unboxedValue);

            Console.WriteLine("\nPress Enter to continue\n");
            Console.ReadLine();
        }

        public void Task_9()
        {
            Console.WriteLine("Enter a value for the first variable:");
            string firstinput = Console.ReadLine();
            int firstvaluet = int.Parse(firstinput);

            Console.WriteLine("Enter a value for the second variable:");
            string secondinput = Console.ReadLine();
            short secondvalue = short.Parse(secondinput);

            int convertedValue = (int)secondvalue;
            Console.WriteLine("Explicit Conversion: " + convertedValue);

            short originalValue = (short)firstvaluet;
            Console.WriteLine("Implicit conversion: " + originalValue);

        }
    }
}
