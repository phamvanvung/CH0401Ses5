using System;
namespace CH0401Ses5BasicInheritance
{
    public class MiniVan: Car //extends the car
    {
        //An extension of the car
        public void TestMethod(){
            //can access to the public member
            Speed = 10;//OK
            //Cannot access to the private member
            //currSpeed = 10;//error
        }
    }
}
