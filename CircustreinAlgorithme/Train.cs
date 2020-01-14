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
                wagons[i].LookIfAnimalFits(animals);
            }
            if (animals.Any())
            {
                AddWagon();
            }
        }

        public void AddWagon()
        {
            Wagon wagon = new Wagon();
            wagons.Add(wagon);
        }
    }
}

