using System;
using System.Text;
using System.Text.RegularExpressions;

namespace CSharpBasics
{
    class Homework_1
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



            ////Первый вариант

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
            //Первый вариант
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

            //Второй вариант
            Console.WriteLine("Введите имя, фамилию и возраст через пробел:");
            string input = Console.ReadLine();
            string[] inputParts = input.Split(' ');

            //Trim() Удаляет символы пробелы из начала и конца строки
            string firstName1 = inputParts[0].Trim();
            string lastName1 = inputParts[1].Trim();
            var age1 = inputParts[2].Trim();
            //int age = int.TryParse(inputParts[2].Trim(), out int parsedAge) ? parsedAge : 0;

            Console.WriteLine("\"Сколько вам лет?\", - спросил полицейский.");
            Console.WriteLine("\"{0}\", - {1} {2} ответил.\n", age1, firstName1, lastName1);


        }

        public void Task_3()
        {
            //Первый вариант решения

            Console.WriteLine("Введите 3-4 слова через Enter:");

            string word1 = Console.ReadLine();
            string word2 = Console.ReadLine();
            string word3 = Console.ReadLine();
            string word4 = Console.ReadLine();

            // .Join("") Если так то слова слипнуться, а ессли .Join("") то добавится пробел. По ТЗ вроде не нада пробел
            Console.WriteLine("\n" + string.Join("", $" Результат командой Join   ", word1, word2, word3, word4));

            Console.WriteLine(string.Concat($" Результат командой Concat ", word1, word2, word3, word4));

            Console.WriteLine("\n Нажмите Enter чтобы продолжить \n");
            Console.ReadLine();


            // Второй вариант решения

            Console.WriteLine("Введите 3-4 слова через пробел:");

            string input = Console.ReadLine();
            string[] words = input.Split(' ');

            Console.WriteLine($"\n Результат командой Join   " + string.Join("", words));

            Console.WriteLine($" Результат командой Concat " + string.Concat(words));

            Console.WriteLine("\n Нажмите Enter чтобы продолжить \n");
            Console.ReadLine();

            // Третий вариант решения

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

            //string[] substrings = { substring1, substrin2 };
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
            // Первый вариантан

            Console.WriteLine("Введите букву в нижнем регистре:");

            char loweLetter = Console.ReadLine()[0];
            char uppeLetter = char.ToUpper(loweLetter);

            Console.WriteLine($"Результат: {uppeLetter}\n");

            // Второйервый вариантан

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
}
