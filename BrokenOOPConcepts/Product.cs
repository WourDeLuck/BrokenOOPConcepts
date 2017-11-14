using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokenOOPConcepts
{
    /// <summary>
    /// An example of incorrect inheritance concept usage.
    /// Class Product is a base class. There are also two child classes which are
    /// "Liquid" and "Solid".
    /// As it seems, both of the child classes have the same field "Price" which is
    /// a violation of inheritance concept in OOP. 
    /// Since it's better to add the field to the base class.
    /// </summary>
    public class Product
    {
        // Id of the product
        public int Id { get; set; }
        // Name of the product
        public string Name { get; set; }
        // Type of the product
        public string Type { get; set; }

        // Class constructor
        public Product(int id, string name, string type)
        {
            this.Id = id;
            this.Name = name;
            this.Type = type;
        }
    }

    /// <summary>
    /// Class Solid is a child class of the Product class.
    /// </summary>
    public class Solid : Product
    {    
        // Price of the Solid product
        public double Price { get; set; }
        // Weight of the Solid product
        public double Weight { get; set; }
        // Amount of units of the Solid product
        public int Units { get; set; }

        // Class constructor
        public Solid(int id, string name, string type, double price, double weight, int units): base (id, name, type)
        {
            this.Price = price;
            this.Weight = weight;
            this.Units = units;
        }
    }

    /// <summary>
    /// Class Liquid is a child class of the Product class.
    /// </summary>
    public class Liquid : Product
    {
        // Price of the Liquid product
        public double Price { get; set; }
        // Volume of the Liquid product
        public double Volume { get; set; }

        // Class constructor
        public Liquid(int id, string name, string type, double price, double volume): base (id, name, type)
        {
            this.Price = price;
            this.Volume = volume;
        }
    }
}
