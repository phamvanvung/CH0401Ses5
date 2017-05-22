using System;

namespace CH0401Ses5EmployeeApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Employee e = new Employee("A", 1, 100);
            Employee e;
            Manager m = new Manager("ManName", 1, 100, 30, "ManSSN", 100);
            Console.WriteLine("Manager display status");
            m.DisplayStatus();
            e = m;
            Console.WriteLine("Display manager status, using employee ref");
            e.DisplayStatus();

        }
    }
}
