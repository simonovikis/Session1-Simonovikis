using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session1
{
    public class Assignement3
    {
        public static void Main(string[] args)
        {
            Dog dog = new Dog();
            Console.Write("Insert dog's name: ");
            dog.SetName(Console.ReadLine());
            Console.WriteLine($"Dog's name is {dog.GetName()}");
            dog.Eat();
        }
        public abstract class Animal
        {
            private string? Name;
            public void SetName(string name)
            {
                Name = name;
            }
            public string GetName()
            {
                return Name;
            }
            public abstract void Eat();
        }
        public class Dog : Animal
        {
            public override void Eat()
            {
                Console.WriteLine("Eating");
            }
        }
    }
}
