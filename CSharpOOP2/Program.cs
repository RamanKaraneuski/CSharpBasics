using System;

namespace CSharpOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1: Creating an instance of the "Table" class

            Console.WriteLine("--------------Task 1--------------");
            Table myTable = new Table();
            myTable.Material = "Wood";
            myTable.LegsCount = 4;
            myTable.IsFoldable = true;

            myTable.DisplayDetails();

            #endregion

            #region Task 2: Creating an instance of the class "Horse"

            Console.WriteLine("--------------Task 2--------------");
            Horse myHorse = new Horse();
            myHorse.Color = "Black";
            myHorse.Age = 8;
            myHorse.Breed = "Arabian";
            myHorse.ManeLength = 0.8;
            myHorse.IsVaccinated = true;

            myHorse.DisplayDetails();

            #endregion

            #region Task 3: Method for changing the grafting status for an instance of the "Horse" class

            Console.WriteLine("--------------Task 3--------------");
            myHorse.UpdateVaccinationStatus(400);
            myHorse.DisplayDetails();

            #endregion

            #region Task 4: Creation of the 1st instance of the class "Table" with the initialization of the fields

            Console.WriteLine("--------------Task 4--------------");
            Table myTableOne = new Table
            {
                Material = "Wood",
                LegsCount = 4,
                IsFoldable = true
            };

            myTableOne.DisplayDetails();

            #endregion

            #region Task 5: Creating the 2nd instance of the "Table" class using the constructor and initializing the fields

            Console.WriteLine("--------------Task 5--------------");
            Table myTableTwo = new Table
            {
                Material = "Plastic",
                LegsCount = 3,
                IsFoldable = false
            };

            myTableTwo.DisplayDetails();

            #endregion

            #region Task 6: Initialization of the 3rd instance of the "Item" class using a constructor that initializes all fields

            Console.WriteLine("--------------Task 6--------------");
            Item myItemOne = new Item("Book", "1234567890", 29.99);
            myItemOne.DisplayDetails();

            #endregion

            #region Task 7: Creating an instance of the "Item" class with an empty constructor

            Console.WriteLine("--------------Task 7--------------");
            Item myItemTwo = new();
            myItemTwo.Name = "Pen";
            myItemTwo.DisplayDetails();

            #endregion

            #region Task 8: Creating an instance of the "Item" class with a constructor that initializes 1-2 fields

            Console.WriteLine("--------------Task 8--------------");
            Item myItemThree = new Item("Notebook");
            myItemThree.DisplayDetails();

            #endregion

            #region Task 9: Creating a 3rd instance of the "Item" class using a constructor that initializes all fields

            Console.WriteLine("--------------Task 9--------------");
            Item myItemFour = new Item("Phone", "375441811687", 999.99);
            myItemFour.DisplayDetails();

            #endregion

            #region Task 10: Calling the method for changing the grafting status for an instance of the "Horse" class

            Console.WriteLine("--------------Task 10-------------");
            myHorse.UpdateVaccinationStatus(400);
            myHorse.DisplayDetails();

            #endregion

            #region Task 11: Methods with private and internal modifiers

            // The compiler will highlight an error when calling private and internal methods
            //myHorse.PrivateMethod();
            //myHorse.InternalMethod();

            #endregion

            #region Task 12: Creating the 4th instance of the "Horse" class without declaring the field used in the method

            Console.WriteLine("--------------Task 12-------------");
            Horse myHorseFour = new Horse
            {
                Color = "White",
                Age = 5,
                Breed = "Thoroughbred",
                ManeLength = 1.2
            };

            myHorseFour.UpdateVaccinationStatus(200);
            myHorseFour.DisplayDetails();

            #endregion

            #region Task 13: Assigning a default value to one of the fields

            Console.WriteLine("--------------Task 13-------------");
            Horse myHorseFive = new Horse
            {
                Color = "Brown",
                Age = 6,
                Breed = "Mustang",
                ManeLength = 0.9,
                IsVaccinated = true
            };

            Console.WriteLine("Age: " + myHorseFive.Age);

            #endregion

            Console.ReadKey();
        }
    }
}
