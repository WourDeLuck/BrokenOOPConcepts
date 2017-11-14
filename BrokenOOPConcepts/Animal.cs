using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokenOOPConcepts
{
    /// <summary>
    /// An example of incorrect inheritance usage.
    /// Animal class is the base one. And its child Tree inherits methods
    /// and fields of Animal.
    /// What is already a violation of inheritance concept, since
    /// by rules parent and child should be alike. 
    /// </summary>
    public class Animal
    {
        // Name of an animal
        public string Name { get; set; }
        // Type of an animal
        public string Type { get; set; }
        // Age of an animal
        public int Age { get; set; }

        /// <summary>
        /// Eating food
        /// </summary>
        public void Eat()
        {
            Console.WriteLine("Animal is eating");
        }

        /// <summary>
        /// Walking animal
        /// </summary>
        public void Walk()
        {
            Console.WriteLine("Animal is walking");
        }

        /// <summary>
        /// Sleeping animal
        /// </summary>
        public void Sleep()
        {
            Console.WriteLine("Animal is sleeping");
        }

        /// <summary>
        /// Animal has died
        /// </summary>
        public void Die()
        {
            Console.WriteLine("Animal is ded. Not big soup rice");
        }

    }

    /// <summary>
    /// Tree class is a child of "Animal" class.
    /// </summary>
    public class Tree : Animal
    {
        // Tree's height
        public string Height { get; set; }
        // Tree's condition (depends on the seasons)
        public string Condition { get; set; }

        /// <summary>
        /// Tree stays
        /// </summary>
        public void Stay()
        {
            Console.WriteLine("Tree stays. What else can it do?");
        }
    }
}
