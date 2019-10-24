using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircustreinAlgorithme
{
    public class Wagon
    {
        public List<Animal> wagonAnimals = new List<Animal>();

        public override string ToString()
        {
            return string.Join(",", wagonAnimals);
        }

        public List<Animal> LookIfAnimalFits(List<Animal> animals)
        {
            if (!wagonAnimals.Any())
            {
                return animals;
            }
            if (animals[0].race == Animal.Race.Carnivore)
            {
                return null;
            }
            else
            {
                if (wagonAnimals[0].race == Animal.Race.Carnivore)
                {
                    return animals.Where(a => a.size + wagonAnimals.Sum(a => a.size) <= 10 && a.size > wagonAnimals[0].size).ToList();
                }
                else
                {
                    return animals.Where(a => a.size + wagonAnimals.Sum(a => a.size) <= 10).ToList();
                }
            }
        }
    }
}
