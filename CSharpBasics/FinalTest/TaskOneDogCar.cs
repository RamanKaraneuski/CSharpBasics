using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.FinalTest
{

    public interface IMovable
    {
        void Move();
    }

    public abstract class Vehicle : IMovable
    {
        public string Name { get; set; }

        public Vehicle(string name)
        {
            Name = name;
        }

        public abstract void Start();
        public abstract void Stop();

        public void Move()
        {
            Console.WriteLine($"{Name} is moving.");
        }
    }

    public class Dog : IMovable
    {
        public string Name { get; set; }

        public Dog(string name)
        {
            Name = name;
        }

        public void Bark()
        {
            Console.WriteLine($"{Name} is barking.");
        }

        public void Move()
        {
            Console.WriteLine($"{Name} is running.");
        }
    }

    public class Car : Vehicle
    {
        public Car(string name) : base(name)
        {
        }

        public override void Start()
        {
            Console.WriteLine($"{Name} is starting.");
        }

        public override void Stop()
        {
            Console.WriteLine($"{Name} is stopping.");
        }
    }

    class TaskOneDogCar
    {
        static void Main()
        {
            Dog myDog = new Dog("Buddy");
            Car myCar = new Car("Toyota");

            myDog.Bark();
            myDog.Move();

            myCar.Start();
            myCar.Move();
            myCar.Stop();
        }
    }
}
