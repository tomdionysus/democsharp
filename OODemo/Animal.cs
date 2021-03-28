using System;

namespace OODemo
{
    public abstract class Animal : IHouseholdItem
    {
        public Animal()
        {
        }

        protected int noOfLegs;

        public void speak()
        {
            throw new NotImplementedException();
        }

        public int getNoOfLegs()
        {
            return noOfLegs;
        }

        public bool IsAlive()
        {
            throw new NotImplementedException();
        }
    }
}
