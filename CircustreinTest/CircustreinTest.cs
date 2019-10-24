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
        private Wagon wagon;
        [TestInitialize]
        public void Setup()
        {
            wagon = new Wagon();
        }

        [TestMethod]
        public void Empty_List_Should_Return_Empty_List()
        {
            //arrange
            List<Animal> input = new List<Animal>();
            //act
            var output = wagon.LookIfAnimalFits(input);
            //assert
            CollectionAssert.AreEqual(input, output);
        }

        [TestMethod]
        public void One_Animal_In_List_Return_One_Animal()
        {
            //arrange
            List<Animal> input = new List<Animal>() { new Animal(3, Animal.Race.Carnivore) };
            //act
            var output = wagon.LookIfAnimalFits(input);
            //assert
            CollectionAssert.AreEqual(input, output);
        }

        [TestMethod]
        public void Two_Animals_In_List_Return_One_Animal()
        {
            //arrange
            List<Animal> input = new List<Animal>() { new Animal(5, Animal.Race.Herbivore), new Animal(3, Animal.Race.Herbivore) };
            wagon.wagonAnimals.Add(new Animal(3, Animal.Race.Carnivore));
            //act
            var output = wagon.LookIfAnimalFits(input);
            var expected = new List<Animal>() { new Animal(5, Animal.Race.Herbivore) };
            //assert
            Assert.IsTrue(output.SequenceEqual(expected, new MyAnimalEqualityComparer()));
        }

        [TestMethod]
        public void Two_Animals_In_List_Return_Two_Animals()
        {
            //arrange
            List<Animal> input = new List<Animal>() { new Animal(5, Animal.Race.Herbivore), new Animal(3, Animal.Race.Herbivore) };
            wagon.wagonAnimals.Add(new Animal(1, Animal.Race.Carnivore));
            //act
            var output = wagon.LookIfAnimalFits(input);
            var expected = new List<Animal>() { new Animal(5, Animal.Race.Herbivore) , new Animal(3, Animal.Race.Herbivore)};
            //assert
            Assert.IsTrue(output.SequenceEqual(expected, new MyAnimalEqualityComparer()));
        }
    }
}
