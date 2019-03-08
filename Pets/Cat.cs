using System;
namespace Pets
{
    public class Cat : Pet
    {
        public Cat(string Name, string Owner, double Weight) : base(Name, Owner, Weight)
        {
            type = "Cat";
        }

        public string meow(int count)
        {
            int i = 0;
            string sound = "";
            do
            {
                sound = sound + "meow.";
                i++;
            } while (i < count);
            return sound;
        }

    }
}
