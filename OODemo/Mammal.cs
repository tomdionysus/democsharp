using System;
namespace OODemo
{
    public class Mammal : Animal
    {
        public Mammal()
        {
        }

        public new void speak()
        {
            Console.WriteLine("<Mammal Noise>");
        }
    }
}
