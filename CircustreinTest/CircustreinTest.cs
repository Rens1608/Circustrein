using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CircustreinAlgorithme;
using System.Collections.Generic;
using System.Linq;

namespace CircustreinTest
{
    [TestClass]
    public class CircustreinTest
    {
        [TestMethod]
        public void One_Animal_In_List_Return_True()
        {
            //arrange
            Wagon wagon = new Wagon();
            List<Animal> input = new List<Animal>() { new Animal(3, Animal.Race.Carnivore) };
            //act
            bool output = wagon.LookIfAnimalFits(input);
            //assert
            Assert.AreEqual(true, output);
        }

        [TestMethod]
        public void Place_Herbivore_With_Carnivore_In_Wagon_Succeeds()
        {
            Wagon wagon = new Wagon();
            List<Animal> input = new List<Animal>() { new Animal(3, Animal.Race.Herbivore) };
            wagon.wagonAnimals.Add(new Animal(1, Animal.Race.Carnivore));
            bool output = wagon.LookIfAnimalFits(input);
            Assert.AreEqual(true, output);
        }

        [TestMethod]
        public void Place_Herbivore_With_Carnivore_In_Wagon_Fails()
        {
            Wagon wagon = new Wagon();
            List<Animal> input = new List<Animal>() { new Animal(3, Animal.Race.Herbivore) };
            wagon.wagonAnimals.Add(new Animal(3, Animal.Race.Carnivore));
            bool output = wagon.LookIfAnimalFits(input);
            Assert.AreEqual(false, output);
        }

        [TestMethod]
        public void Place_Herbivore_With_Animals_In_Wagon_Fails()
        {
            Wagon wagon = new Wagon();
            List<Animal> input = new List<Animal>() { new Animal(5, Animal.Race.Herbivore) };
            wagon.wagonAnimals.Add(new Animal(3, Animal.Race.Carnivore));
            wagon.wagonAnimals.Add(new Animal(5, Animal.Race.Herbivore));
            bool output = wagon.LookIfAnimalFits(input);
            Assert.AreEqual(false, output);
        }
    }
}
