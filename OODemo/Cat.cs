using System;
namespace OODemo
{
    public class Cat : Mammal, INamed
    {
        public Cat()
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
            return "Cat";
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
