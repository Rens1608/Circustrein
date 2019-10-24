using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircustreinAlgorithme
{
    public class Train
    {
        public List<Wagon> wagons = new List<Wagon> { new Wagon()};
        Wagon wagon = new Wagon();

        public void TryToPlaceAnimalInWagon(List<Animal> animals)
        {
            for (int i = 0; i < wagons.Count; i++)
            {
                if (!animals.Any())
                {
                    break;
                }
                if (wagons[i].LookIfAnimalFits(animals) == null || !wagons[i].LookIfAnimalFits(animals).Any())
                {
                    AddWagon();
                }
                else
                {
                    var selectedAnimal = wagons[i].LookIfAnimalFits(animals).FirstOrDefault();
                    wagons[i].wagonAnimals.Add(selectedAnimal);
                    animals.Remove(selectedAnimal);
                }
            }
        }

        public void AddWagon()
        {
            Wagon wagon = new Wagon();
            wagons.Add(wagon);
        }
    }
}

