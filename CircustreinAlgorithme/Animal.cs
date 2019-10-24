using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircustreinAlgorithme
{
    public class Animal
    {
        public enum Race { Herbivore, Carnivore }
        public Race race { get; set; }
        public int size { get; set; }

        public Animal(int size, Race race)
        {
            this.size = size;
            this.race = race;
        }

        public override string ToString()
        {
            return race.ToString() + size.ToString();
        }
    }
}
