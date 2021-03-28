using System;
namespace OODemo
{
    public interface INamed: IHouseholdItem
    {
        public String getName();
        public void setName(String n);

        public String getType();
    }
}
