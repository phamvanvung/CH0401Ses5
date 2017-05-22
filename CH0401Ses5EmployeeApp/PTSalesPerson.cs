using System;
namespace CH0401Ses5EmployeeApp
{
    public sealed class PTSalesPerson : SalesPerson
    {
		public PTSalesPerson(string name, int id, float pay, int age, string ssn,
						   int numberOfSales)
        :base( name, id, pay, age, ssn, numberOfSales)
        {
        }
    }
}
