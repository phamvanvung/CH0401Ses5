using System;

namespace CH0401Ses5EmployeeApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Manager m = new Manager("Man1", 1, 100, 30, "Man1", 100);
            m.GiveBonus(300);
            SalesPerson s = new SalesPerson("Sale1", 2, 50, 20, "Sale1", 100);
            s.GiveBonus(200);
            m.DisplayStatus();
            s.DisplayStatus();
        }
    }
}
