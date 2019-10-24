using System.Collections.Generic;
using CircustreinAlgorithme;

namespace CircustreinTest
{
    internal class MyAnimalEqualityComparer : IEqualityComparer<Animal>
    {
        public bool Equals(Animal x, Animal y)
        {
            if (ReferenceEquals(x, y)) return true;

            if (ReferenceEquals(x, null) || Animal.ReferenceEquals(y, null)) return false;

            return x.size == y.size && x.race == y.race;
        }

        public int GetHashCode(Animal obj)
        {
            if (ReferenceEquals(obj, null)) return 0;

            int hashCodeSize = obj.size == null ? 0 : obj.size.GetHashCode();
            int hasCodeRace = obj.race.GetHashCode();

            return hashCodeSize ^ hasCodeRace;
        }
    }
}