namespace CSharpOOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Horse myHorse = new Horse
            {
                Color = "Black",
                Age = 8,
                Breed = "Arabian",
                IsVaccinated = false
            };

            myHorse.ManeLength = 0.5;

            Horse myHorseOne = new Horse
            {
                Color = "Black",
                Age = 8,
                Breed = "Arabian",
                ManeLength = 0.8,
                IsVaccinated = false
            };

            Horse myHorseTwo = new Horse
            {
                Color = "White",
                Age = 3,
                Breed = "Friesian",
                ManeLength = 1.5,
                IsVaccinated = true
            };

            Horse myHorseThree = new Horse
            {
                Color = "Black",
                Age = 7,
                Breed = "Arabian",
                ManeLength = 0.9,
                IsVaccinated = false
            };

            Horse myHorseFour = new Horse
            {
                Color = "Brown",
                Age = 5,
                Breed = "Quarter Horse",
                ManeLength = 1.2,
                IsVaccinated = true
            };

            myHorseOne.UpdateVaccinationStatus(400);

            myHorseThree.PublicMethod();    
            // Вызов публичного метода
            // myHorse.PrivateMethod(); 
            // Error Line: Нельзя вызвать приватный метод вне класса Horse                         
            // myHorse.InternalMethod(); 
            // Error Line: Нельзя вызвать внутренний метод вне сборки

            Horse.InternalMethodCaller(myHorseThree);  // Вызов внутреннего метода с использованием метода-обертки

            myHorseFour.UpdateVaccinationStatus(200);

            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("My horse 0 details:");
            Console.WriteLine("Color: " + myHorse.Color);
            Console.WriteLine("Age: " + myHorse.Age);
            Console.WriteLine("Breed: " + myHorse.Breed);
            Console.WriteLine("Mane Length: " + myHorse.ManeLength);
            Console.WriteLine("Vaccination Status: " + (myHorse.IsVaccinated ? "Vaccinated" : "Not Vaccinated"));

            Console.WriteLine();

            Console.WriteLine("My horse 1 details:");
            Console.WriteLine("Color: " + myHorseOne.Color);
            Console.WriteLine("Age: " + myHorseOne.Age);
            Console.WriteLine("Breed: " + myHorseOne.Breed);
            Console.WriteLine("Mane Length: " + myHorseOne.ManeLength);
            Console.WriteLine("Vaccination Status: " + (myHorseOne.IsVaccinated ? "Vaccinated" : "Not Vaccinated"));

            Console.WriteLine();

            Console.WriteLine("My horse 2 details:");
            Console.WriteLine("Color: " + myHorseTwo.Color);
            Console.WriteLine("Age: " + myHorseTwo.Age);
            Console.WriteLine("Breed: " + myHorseTwo.Breed);
            Console.WriteLine("Mane Length: " + myHorseTwo.ManeLength);
            Console.WriteLine("Vaccination Status: " + (myHorseTwo.IsVaccinated ? "Vaccinated" : "Not Vaccinated"));

            Console.WriteLine();

            Console.WriteLine("My horse 3 details:");
            Console.WriteLine("Color: " + myHorseThree.Color);
            Console.WriteLine("Age: " + myHorseThree.Age);
            Console.WriteLine("Breed: " + myHorseThree.Breed);
            Console.WriteLine("Mane Length: " + myHorseThree.ManeLength);
            Console.WriteLine("Vaccination Status: " + (myHorseThree.IsVaccinated ? "Vaccinated" : "Not Vaccinated"));

            Console.WriteLine();

            Console.WriteLine("My horse 4 details:");
            Console.WriteLine("Color: " + myHorseFour.Color);
            Console.WriteLine("Age: " + myHorseFour.Age);
            Console.WriteLine("Breed: " + myHorseFour.Breed);
            Console.WriteLine("Mane Length: " + myHorseFour.ManeLength);
            Console.WriteLine("Vaccination Status: " + (myHorseFour.IsVaccinated ? "Vaccinated" : "Not Vaccinated"));

            Console.WriteLine("Press Enter to continue");
            Console.ReadKey();
            

            // Создание объектов с использованием различных конструкторов
            Item item1 = new Item("Book", 5, 10.99m);
            Item item2 = new Item();
            Item item3 = new Item("Pen");

            // Вывод деталей каждого предмета
            item1.DisplayDetails();
            item2.DisplayDetails();
            item3.DisplayDetails();
        }

        
      

    }
}