using System;

namespace CH0401Ses5BasicInheritance
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Car c = new Car(80);
            c.Speed = 50;
            Console.WriteLine("My car is going {0} MPH.", c.Speed);
            Console.ReadLine();
        }
    }
}
