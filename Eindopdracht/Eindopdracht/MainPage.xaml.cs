using Eindopdracht.Models;
using Eindopdracht.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Eindopdracht
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            TestPeople();
        }

        private async void TestPeople()
        {
            lvwStarWarsPeople.ItemsSource = await StarWarsRepository.GetPeoplesAsync();

            List<StarWarsPeople> peoples = await StarWarsRepository.GetPeoplesAsync();

            foreach (StarWarsPeople people in peoples)
            {
                Debug.WriteLine($"{people.Gender}");
            }
        }
    }
}
