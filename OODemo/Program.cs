using System;
using System.Collections.Generic;

namespace OODemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> allAnimals = new List<Animal>();

            Cat gallagher = new Cat();
            gallagher.setName("Gallagher");
            allAnimals.Add(gallagher);

            Dog jack = new Dog(); jack.setName("Jack");
            allAnimals.Add(jack);

            List<IHouseholdItem> householdThings = new List<IHouseholdItem>();

            householdThings.Add(gallagher);
            householdThings.Add(jack);

            Car lemon = new Car(); lemon.setName("Lemon");
            householdThings.Add(lemon);

            Parrot polly = new Parrot(); polly.setName("Sirocco");
            householdThings.Add(polly);

            Console.WriteLine("Things in house");
            Console.WriteLine("---------------");
            foreach (INamed i in householdThings)
            {
                Console.WriteLine(i.getName()+" ("+i.getType()+") ("+(i.IsAlive() ? "Alive" : "Dead" )+")");
            }
        }
    }
}
