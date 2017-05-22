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
        public override void DisplayStatus()
        {
            base.DisplayStatus();
            Console.WriteLine("Number of sales {0}", NumberOfSales);
        }
        public override void GiveBonus(float amount)
        {
            int saleBonus =0;
            if (NumberOfSales >= 0 && NumberOfSales <= 100){
                saleBonus = 10;
            }else if (NumberOfSales >= 101 && NumberOfSales <= 200) {
                saleBonus = 15;
            }else{
                saleBonus = 20;
            }
            base.GiveBonus(amount*saleBonus);
        }
    }
}
