using System;
namespace CH0401Ses5EmployeeApp
{
    public class Employee
    {
        private string empName;
        public string Name
        {
            get
            {
                return empName;
            }
            set
            {
                if (value.Length > 15)
                {
                    Console.WriteLine("Name exceeds 15 characters!");
                }
                else
                {
                    empName = value;
                }
            }
        }
        public int ID
        {
            get;
            set;
        }
        public float Pay
        {
            get;
            set;
        }
        public int Age
        {
            get;
            set;
        }
        public string SSN
        {
            get;
            set;
        }

        public Employee()
        {
        }
        public Employee(string name, int id, float pay, int age, string ssn)
        {
            Name = name;
            ID = id;
            Pay = pay;
            Age = age;
            SSN = ssn;
        }
        public Employee(string name, int id, float pay) 
            : this(name, id, pay, 0, "")
        {
        }
        public void DisplayStatus(){
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("ID: {0}", ID);
            Console.WriteLine("Pay: {0}", Pay);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("SSN: {0}", SSN);
        }
        public void GiveBonus(float amount){
            Pay += amount;
        }
    }
}
