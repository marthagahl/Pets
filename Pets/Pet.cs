using System;
namespace Pets
{
    public class Pet
    {
        public string type;
        public string name;
        public string owner;
        public double weight;

        public Pet(string Type, string Name, string Owner, double Weight)
        {
            type = Type;
            name = Name;
            owner = Owner;
            weight = Weight;
        }

        public Pet(string Name, string Owner, double Weight)
        {
            name = Name;
            owner = Owner;
            weight = Weight;
            type = "No Type";
        }

        public string getTag()
        {
            return "If lost, call " + owner;
        }
    }
}
