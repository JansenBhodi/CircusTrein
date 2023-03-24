using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Circustrein_Library.Classes;

namespace Circustrein
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Train train = new Train();
        //Change this to the list in the Train class, Use that instead as the itemsSource for the ListView

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddSmallHerbivore(object sender, RoutedEventArgs e)
        {
            AddAnimal(AnimalSize.Small, AnimalType.Herbivore);
        }

        private void AddMediumHerbivore(object sender, RoutedEventArgs e)
        {
            AddAnimal(AnimalSize.Medium, AnimalType.Herbivore);
        }

        private void AddLargeHerbivore(object sender, RoutedEventArgs e)
        {
            AddAnimal(AnimalSize.Large, AnimalType.Herbivore);
        }

        private void AddSmallCarnivore(object sender, RoutedEventArgs e)
        {
            AddAnimal(AnimalSize.Small, AnimalType.Carnivore);
        }

        private void AddMediumCarnivore(object sender, RoutedEventArgs e)
        {
            AddAnimal(AnimalSize.Medium, AnimalType.Carnivore);
        }

        private void AddLargeCarnivore(object sender, RoutedEventArgs e)
        {
            AddAnimal(AnimalSize.Large, AnimalType.Carnivore);
        }

        private void PresetOneLoader(object sender, RoutedEventArgs e)
        {
            LbCurrentAnimals.ItemsSource = null;
            train.AllAnimal.Clear();
            AddAnimal(AnimalSize.Large, AnimalType.Herbivore);
            AddAnimal(AnimalSize.Medium, AnimalType.Herbivore);
            AddAnimal(AnimalSize.Medium, AnimalType.Herbivore);
            AddAnimal(AnimalSize.Small, AnimalType.Herbivore);
            AddAnimal(AnimalSize.Large, AnimalType.Carnivore);
        }

        private void PresetTwoLoader(object sender, RoutedEventArgs e)
        {
            LbCurrentAnimals.ItemsSource = null;
            train.AllAnimal.Clear();
            AddAnimal(AnimalSize.Large, AnimalType.Carnivore);
            AddAnimal(AnimalSize.Large, AnimalType.Herbivore);
            AddAnimal(AnimalSize.Large, AnimalType.Herbivore);
            AddAnimal(AnimalSize.Medium, AnimalType.Herbivore);
            AddAnimal(AnimalSize.Medium, AnimalType.Carnivore);
            AddAnimal(AnimalSize.Small, AnimalType.Herbivore);
        }

        private void PresetThreeLoader(object sender, RoutedEventArgs e)
        {
            LbCurrentAnimals.ItemsSource = null;
            train.AllAnimal.Clear();
            AddAnimal(AnimalSize.Large, AnimalType.Carnivore);
            AddAnimal(AnimalSize.Large, AnimalType.Carnivore);
            AddAnimal(AnimalSize.Large, AnimalType.Herbivore);
            AddAnimal(AnimalSize.Medium, AnimalType.Herbivore);
            AddAnimal(AnimalSize.Medium, AnimalType.Carnivore);
            AddAnimal(AnimalSize.Small, AnimalType.Carnivore);
        }

        private void ListReset(object sender, RoutedEventArgs e)
        {
            LbCurrentAnimals.ItemsSource = null;
            train.AllAnimal.Clear();
        }

        private void StartTrain(object sender, RoutedEventArgs e)
        {
            train.CreateTrain();
            LbCartView.ItemsSource = null;
            LbCartView.ItemsSource = train.CartList;
        }

        public void AddAnimal(AnimalSize Animalsize, AnimalType Animaltype)
        {
            Animal NewAnimal = new Animal(Animalsize, Animaltype);
            train.AllAnimal.Add(NewAnimal);
            LbCurrentAnimals.ItemsSource = null;
            LbCurrentAnimals.ItemsSource = train.AllAnimal;
        }
    }
}
