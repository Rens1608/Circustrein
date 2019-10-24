using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircustreinAlgorithme
{
    public partial class Form1 : Form
    {
        Station station = new Station();

        public Form1()
        {
            InitializeComponent();
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            station.TryToPlaceAllCarnivores();
            station.TryToPlaceAllHerbivores();
            ShowContentOfAllWagons();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (Race.Text == "Herbivore")
            {
                station.animals.Add(new Animal(Convert.ToInt32(Size.Text), Animal.Race.Herbivore));
            }
            else
            {
                station.animals.Add(new Animal(Convert.ToInt32(Size.Text), Animal.Race.Carnivore));
            }
        }

        private void ShowContentOfAllWagons()
        {
            MessageBox.Show(station.ContentOfWagons());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            station.animals.Add(new Animal (3 , Animal.Race.Carnivore ));
            station.animals.Add(new Animal(3, Animal.Race.Carnivore));
            station.animals.Add(new Animal(3, Animal.Race.Herbivore));
            station.animals.Add(new Animal(5, Animal.Race.Herbivore));
        }
    }
}
