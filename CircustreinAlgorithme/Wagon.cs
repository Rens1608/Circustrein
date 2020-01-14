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

        public bool LookIfAnimalFits(List<Animal> animals)
        {
            if (!wagonAnimals.Any())
            {
                wagonAnimals.Add(animals.First());
                animals.Remove(animals.First());
                return true;
            }
            if (animals[0].race == Animal.Race.Carnivore)
            {
                return false;
            }
            else
            {
                if (wagonAnimals[0].race == Animal.Race.Carnivore)
                {
                    try
                    {
                        var animal = animals.Where(a => a.size + wagonAnimals.Sum(a => a.size) <= 10 && a.size > wagonAnimals[0].size).First();
                        wagonAnimals.Add(animal);
                        animals.Remove(animal);
                        return true;
                    }
                    catch
                    {
                        return false;
                    }
                }
                else
                {
                    try
                    {
                        var animal = animals.Where(a => a.size + wagonAnimals.Sum(a => a.size) <= 10).First();
                        wagonAnimals.Add(animal);
                        animals.Remove(animal);
                        return true;
                    }
                    catch
                    {
                        return false;
                    }
                }
            }
        }
    }
}
