using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IAnimal
    {
        void Name(string name);
        void Owner(string owner);
        void Species(string species);
    }
    class Animal : IAnimal
    {
        public string Name { get; set; }
        public string Owner { get; set; }
        public string Species { get; set; }

        void IAnimal.Name(string name)
        {
            this.Name = name;

        }
        void IAnimal.Owner(string owner)
        {
            this.Owner = owner;

        }
        void IAnimal.Species(string species)
        {
            this.Species = species;

        }
    }
}
