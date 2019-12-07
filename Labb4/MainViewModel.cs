using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace Labb4
{
    public class MainViewModel : SimpleViewModel
    {
        private readonly List<Country> listOfCountries;
        private Country currentCountry;
        private int indexCounter = 0;
        public ICommand NextCountryCommand { get; private set; }
        public ICommand PreviousCountryCommand { get; private set; }
        public MainViewModel()
        {
            CountryRepository countryRepository = new CountryRepository();
            listOfCountries = countryRepository.GetCountries();
            CurrentCountry = listOfCountries[0];

            NextCountryCommand = new Command(nextButtonPressed);
            PreviousCountryCommand = new Command(previousButtonPressed);
            
        }

        public Country CurrentCountry
        {
            get {
                return currentCountry;
            }
            set
            {
                SetPropertyValue(ref currentCountry, value);
            }
        }

        public void nextButtonPressed()
        {
            Console.WriteLine("NÄSTA");
            indexCounter++;
            if (indexCounter >= listOfCountries.Count)
            {
                indexCounter = 0;
            }
            CurrentCountry = listOfCountries[indexCounter];
        }

        private void previousButtonPressed()
        {
            Console.WriteLine("BACKA");
            indexCounter--;
            if (indexCounter < 0)
            {
                indexCounter = listOfCountries.Count - 1;
                Console.WriteLine(listOfCountries[indexCounter].Name);
            }
            CurrentCountry = listOfCountries[indexCounter];
        }
    }
}
