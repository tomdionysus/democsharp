using System;
namespace OODemo
{
    public class Dog : Mammal, INamed
    {
        public Dog()
        {
            noOfLegs = 4;
        }

        protected String name;

        public String getName()
        {
            return name;
        }

        public String getType()
        {
            return "Dog";
        }

        public void setName(String n)
        {
            name = n;
        }

        public new bool IsAlive()
        {
            return true;
        }
    }
}
