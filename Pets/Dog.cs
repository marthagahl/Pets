using System;
namespace Pets
{
    public class Dog : Pet
    {
        public Dog(string Name, string Owner, double Weight) : base (Name, Owner, Weight)
        {
            type = "Dog";
        }

        public string bark (int count)
        {
            int i = 0;
            string sound = "";
            do
            {
                sound = sound + "bark!";
                i++;
            } while (i < count);
            return sound;
        }
    }
}
