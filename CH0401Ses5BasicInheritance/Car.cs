using System;
namespace CH0401Ses5BasicInheritance
{
    public class Car
    {
        public readonly int maxSpeed;
        private int currSpeed;
        public int Speed
        {
            get { return currSpeed; }
            set{
                currSpeed = value;
                if(currSpeed> maxSpeed){
                    currSpeed = maxSpeed;
                }
            }
        }
        public Car()
        {
            maxSpeed = 55;
        }
        public Car(int maxSpeed)
        {
            this.maxSpeed = maxSpeed;
        }
    }
}
