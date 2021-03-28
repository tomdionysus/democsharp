using System;
namespace OODemo
{
    public class Parrot : Mammal, INamed
    {
        public Parrot()
        {
            noOfLegs = 4;
        }

        protected String name;

        public String getName()
        {
            return name;
        }

        public void setName(String n)
        {
            name = n;
        }

        public String getType()
        {
            return "Parrot";
        }

        public new bool IsAlive()
        {
            return false;
        }

    }
}
