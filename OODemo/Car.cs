using System;
namespace OODemo
{
    public class Car: INamed
    {
        public Car()
        {
        }

        private string Name;

        public string getName()
        {
            return this.Name;
        }

        public String getType()
        {
            return "Car";
        }

        public void setName(string n)
        {
            Name = n;
        }

        public bool IsAlive()
        {
            return false;
        }
    }
}
