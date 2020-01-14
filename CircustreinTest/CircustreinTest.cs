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
        public void Empty_List_Should_Return_False()
        {
            //arrange
            List<Animal> input = new List<Animal>();
            //act
            bool output = wagon.LookIfAnimalFits(input);
            //assert
            Assert.AreEqual(false, output);
        }

        [TestMethod]
        public void One_Animal_In_List_Return_True()
        {
            //arrange
            List<Animal> input = new List<Animal>() { new Animal(3, Animal.Race.Carnivore) };
            //act
            bool output = wagon.LookIfAnimalFits(input);
            //assert
            Assert.AreEqual(true, output);
        }
    }
}
