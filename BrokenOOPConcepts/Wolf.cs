using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokenOOPConcepts
{
    /// <summary>
    /// Wolf class inherit fields and methods of Animal. Also implements interface IFlyable.
    /// Since interfaces can have many implementations, it allows us to put it everywhere.
    /// But in this case it's unnecessary.
    /// </summary>
    public class Wolf : Animal, IFlyable
    {
        // Fur color of wolf
        public string FurColor { get; set; }

        /// <summary>
        /// HasWings implementation
        /// </summary>
        public void HasWings()
        {
            Console.WriteLine("Look at my wolf wings");
        }

        /// <summary>
        /// CanFly implementation
        /// </summary>
        public void CanFly()
        {
            Console.WriteLine("I believe I can fly");
        }
    }

    /// <summary>
    /// Another example of incorrect polymorphism usage is in Bird class.
    /// Since interface requiers a complete methods overriding, the mistale is in
    /// "empty" override.
    /// </summary>
    public class Bird : Animal, IFlyable
    {
        // Feather color of jay
        public string FeatherColor { get; set; }

        /// <summary>
        /// Empty HasWings implementation
        /// </summary>
        public void HasWings()
        {

        }

        /// <summary>
        /// Empty CanFly implementation
        /// </summary>
        public void CanFly()
        {

        }
    }
}
