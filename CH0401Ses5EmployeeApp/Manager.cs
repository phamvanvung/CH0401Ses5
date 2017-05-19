using System;
namespace CH0401Ses5EmployeeApp
{
    public class Manager : Employee//Manager is an employee too
    {
        public Manager(string name, int id, float pay, int age, string ssn
                       ,int stockOptions)
            : base( name, id, pay, age, ssn)
        {
            StockOptions = stockOptions;
        }

        public int StockOptions
        {
            get;
            set;
        }
    }
}
