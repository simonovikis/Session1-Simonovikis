using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session1
{
    public class Assignement4
    {
        public interface IVehicle
        {
            void Drive();
            bool Refuel(int amount);
        }


        public class Program
        {
            public static void Main(string[] args) 
            {
                Console.Write("Enter the amount of gasoline to refuel:");
                int refuelAmount = Convert.ToInt32(Console.ReadLine());
                var car = new Car(refuelAmount);
                car.Drive();
                car.Refuel(50);
                car.Drive();
            }
        }


        public class Car : IVehicle
        {
            public int amount;
            public Car(int startingAmount)
            {
                amount = startingAmount;
            }
            public void Drive()
            {
                if (amount > 0)
                {
                    Console.WriteLine("The car is driving.");
                }
                else
                {
                    Console.WriteLine("No gasoline. Refuel needed.");
                }
            }
            public bool Refuel(int amount)
            {
                if(amount > 0)
                {
                    this.amount = amount;
                    return true;
                }
                return false;
            }
        }
    }
}
