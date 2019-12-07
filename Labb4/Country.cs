using System;
namespace Labb4
{
    public class Country
    {
        public string Name { get; set; }
        public string Currency { get; set; }
        public double Population { get; set; }
        public string Picture { get; set; }
        public string Description { get; set; }

        public Country(string name, string currency, double population, string picture, string description)
        {
            this.Name = name;
            this.Currency = currency;
            this.Population = population;
            this.Picture = picture;
            this.Description = description;
        }
    }
}
