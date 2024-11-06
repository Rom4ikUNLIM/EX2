using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Chapter_EXR
{
    class Car
    {
        public int speed = 0;
        public int maxspeed = 240;

        public void Accelerate(int increment)
        {
            while (speed < maxspeed)
            {
                speed += increment;
                if (speed > maxspeed)
                {
                    speed = maxspeed;
                }

                Console.WriteLine("Current speed: {0}", speed);
                Thread.Sleep(2000);
            }

            Console.WriteLine("Max speed reached: {0}", speed);
        }
    }

    class Amphibia : Car
    {
        public new int maxspeed = 100;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Choose type of car: Car or Amphibia");
        string choice = Console.ReadLine().ToLower();

        Car vehicle;

        if (choice == "car")
        {
            vehicle = new Car();
        }
        else if (choice == "amphibia")
        {
            vehicle = new Amphibia();
        }
        else
        {
            Console.WriteLine("Invalid choice. Please choose Car or Amphibia");
            return;
        }

        Console.Write("Enter acceleration increment (max 50): ");
        if (int.TryParse(Console.ReadLine(), out int increment) && increment > 0)
        {
            int maxIncrement = 50;
            if (increment > maxIncrement)
            {
                Console.WriteLine($"Increment is too high! The maximum allowed is {maxIncrement}.");
            }
            else
            {
                vehicle.Accelerate(increment);
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a positive number.");
        }
    }
}
