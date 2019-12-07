using System;
using System.Collections.Generic;

namespace Labb4
{
    public class CountryRepository
    {
        public List<Country> Countries = new List<Country>();

        public List<Country> GetCountries()
        {
            Country sweden = new Country(name: "Sweden", currency: "SEK", population: 10120000, picture: "sweden.png", description: "Sweden, officially the Kingdom of Sweden, is a Nordic country on the Scandinavian Peninsula in Northern Europe. It has been a member of the European Union since 1 January 1995. Its capital city is Stockholm.");
            Country denmark = new Country(name: "Denmark", currency: "EUR", population: 5603000, picture: "denmark.png", description: "Denmark is a Scandinavian country comprising the Jutland Peninsula and numerous islands. It's linked to nearby Sweden via the Öresund bridge. Copenhagen, its capital, is home to royal palaces and colorful Nyhavn harbor, plus the Tivoli amusement park and the iconic “Little Mermaid” statue. Odense is writer Hans Christian Andersen’s hometown, with a medieval core of cobbled streets and half-timbered houses.");
            Country norway = new Country(name: "Norway", currency: "NOR", population: 5328000, picture: "norway.png", description: "Norway is a Scandinavian country encompassing mountains, glaciers and deep coastal fjords. Oslo, the capital, is a city of green spaces and museums. Preserved 9th-century Viking ships are displayed at Oslo’s Viking Ship Museum. Bergen, with colorful wooden houses, is the starting point for cruises to the dramatic Sognefjord. Norway is also known for fishing, hiking and skiing, notably at Lillehammer’s Olympic resort.");

            Countries.Add(sweden);
            Countries.Add(denmark);
            Countries.Add(norway);

            return Countries;
        }
    }
}