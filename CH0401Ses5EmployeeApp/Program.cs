using System;

namespace CH0401Ses5EmployeeApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            SalesPerson sp = new SalesPerson("Mr. A", 1, 100, 20, "abc", 100);
            //sp.Name = "Mr. A";
            //sp.Age = 20;
            //sp.NumberOfSales = 100;
            sp.DisplayStatus();
        }
    }
}
