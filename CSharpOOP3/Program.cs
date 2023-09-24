using System;

namespace CSharpOOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            Console.WriteLine("Task 1");

            Horse horse = new Horse();

            // Попытка записи значения в свойство IsCompetitionReady

            //horse.IsCompetitionReady = true; // Error Line: Свойство доступно только для чтения

            // Попытка чтения значения свойства Speed
            Console.WriteLine(horse.Speed); // Выведет значение скорости (Будет 0)

            // Попытка записи значения в свойство Speed
            horse.Speed = 10.0; // Устанавливает значение скорости (Будет 10)

            // Попытка чтения значения свойства Speed
            Console.WriteLine(horse.Speed); // Выведет значение скорости

            Console.WriteLine();

            #endregion

            #region Task 2
            Console.WriteLine("Task 2");

            horse = new Horse();

            // Попытка чтения поля IsCompetitionReady
            Console.WriteLine(horse.IsCompetitionReady); // Error Line: Свойство доступно только для чтения

            // Попытка записи значения в поле Speed
            horse.Speed = 30.0; // Error Line: Свойство доступно только для записи

            Console.WriteLine();

            #endregion

            #region Task 3
            Console.WriteLine("Task 3");

            horse = new Horse();

            // Изменение поля, добавление геттера и сеттера
            horse.Name = "Black Beauty";
            Console.WriteLine(horse.Name);

            Console.WriteLine();

            #endregion

            #region Task 4
            Console.WriteLine("Task 4");

            // Вызов статического поля
            Console.WriteLine(Horse.Kind); // Выведет "Horse"

            // Присваивание значения статическому полю
            Horse.Kind = "Pony";

            Console.WriteLine(Horse.Kind); // Выведет "Pony"

            Console.WriteLine();

            #endregion

            #region Task 5
            Console.WriteLine("Task 5");

            // Вызов статического метода
            Horse.ShowMessage();

            Console.WriteLine();

            #endregion

            #region Task 6
            Console.WriteLine("Task 6");

            horse = new Horse();
            horse.Speed = 20.0;

            // Вызов статических методов из класса-помощника
            HorseHelper.PrintHorseData(horse);
            HorseHelper.PrintHorseSpeed(horse);

            Console.WriteLine();

            #endregion

            #region Task 7
            Console.WriteLine("Task 7");

            horse.Name = "Black Beauty";
            horse.Speed = 15.0;

            // Вызов статических методов из класса-помощника
            HorseHelper.PrintHorseData(horse);
            Console.WriteLine();

            HorseHelper.PrintHorseSpeed(horse);
            Console.WriteLine();

            HorseHelper.DisplayHorseInfo(horse);
            Console.WriteLine();

            HorseHelper.DisplayHorseInfoWithColor(horse, "Brown");
            Console.WriteLine();

            #endregion

            Console.ReadLine();
        }
    }
}