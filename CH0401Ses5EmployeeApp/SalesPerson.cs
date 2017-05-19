using System;
namespace CH0401Ses5EmployeeApp
{
    public class SalesPerson: Employee
    {
        public SalesPerson(string name, int id, float pay, int age, string ssn,
                           int numberOfSales
                          ):base(name, id, pay, age, ssn)
        {
            NumberOfSales = numberOfSales;
        }
        public int NumberOfSales
        {
            get;
            set;
        }
    }
}
