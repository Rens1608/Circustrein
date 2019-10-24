using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircustreinAlgorithme
{
    public class Station
    {
        Train train = new Train();
        public List<Animal> animals = new List<Animal>();

        public void TryToPlaceAllCarnivores()
        {
            List<Animal> carnivores = animals.Where(a => a.race == Animal.Race.Carnivore).ToList();
            while (carnivores.Any())
            {
                train.TryToPlaceAnimalInWagon(carnivores);
            }
            animals.RemoveAll(a => a.race == Animal.Race.Carnivore);
        }

        public void TryToPlaceAllHerbivores()
        {
            while (animals.Any())
            {
                train.TryToPlaceAnimalInWagon(animals);
            }
        }

        public string ContentOfWagons()
        {
            return string.Join(" | ", train.wagons);
        }
    }
}
