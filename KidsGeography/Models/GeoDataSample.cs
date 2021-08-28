using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KidsGeography
{
    public static class GeoDataSample
    {
        static GeoDataSample()
        {
            Data = new GeoData();
            Data.Countries = new List<Country>
            {
                new Country{ Capital="Algiers", Currency = "Dinar", Id="DZ", Level= "Easy", Name="Algeria"},
                new Country{ Capital="Rabat", Currency = "Dirham", Id="MA", Level= "Easy", Name="Morroco"},
                new Country{ Capital="Paris", Currency = "Euro", Id="FR", Level= "Easy", Name="France"},
                new Country{ Capital="Madrid", Currency = "Euro", Id="SP", Level= "Easy", Name="Spain"},
                new Country{ Capital="Tunis", Currency = "Dinar", Id="TN", Level= "Easy", Name="Tunisia"},
                new Country{ Capital="Ryadh", Currency = "Ryal", Id="SA", Level= "Easy", Name="Saudi Arabia"},
                new Country{ Capital="Washington", Currency = "Dollar", Id="US", Level= "Easy", Name="USA"},
                new Country{ Capital="Brussels", Currency = "Euro", Id="BE", Level= "Medium", Name="Belgium"},
                new Country{ Capital="Amsterdam", Currency = "Euro", Id="NL", Level= "Medium", Name="Netherlands"},
                new Country{ Capital="Cairo", Currency = "Pound", Id="EG", Level= "Medium", Name="Egypt"},
                new Country{ Capital="Beijin", Currency = "Yuan", Id="CN", Level= "Medium", Name="China"},
                new Country{ Capital="Bern", Currency = "Franc", Id="CH", Level= "Medium", Name="Switzerland"},
                new Country{ Capital="London", Currency = "Pound", Id="UK", Level= "Medium", Name="United Kingdom"},
                new Country{ Capital="Younde", Currency = "Franc", Id="CM", Level= "Hard", Name="Cameroun"},
                new Country{ Capital="Abu Dhabi", Currency = "Dirham", Id="AE", Level= "Hard", Name="Emirates"},
                new Country{ Capital="Bogota", Currency = "Peso", Id="CO", Level= "Hard", Name="Colombia"},
                new Country{ Capital="Islamabad", Currency = "Rupee", Id="PK", Level= "Hard", Name="Pakistan"},
                new Country{ Capital="Islamabad", Currency = "Rupee", Id="PK", Level= "Hard", Name="Pakistan"},
                new Country{ Capital="Dakar", Currency = "Franc", Id="SN", Level= "Hard", Name="Senegal"},
                new Country{ Capital="Buenos Aires", Currency = "Peso", Id="AR", Level= "Hard", Name="Argentina"},
            };
            Data.Towns = new List<Town>
            {
                new Town{ CountryCode = "DZ", Level = "Easy", Name="Blida"},
                new Town{ CountryCode = "DZ", Level = "Easy", Name="Ain Oussera"},
                new Town{ CountryCode = "MA", Level = "Easy", Name="Marrakech"},
                new Town{ CountryCode = "MA", Level = "Easy", Name="Tandja"},
                new Town{ CountryCode = "FR", Level = "Easy", Name="Marseille"},
                new Town{ CountryCode = "FR", Level = "Easy", Name="Lille"},
                new Town{ CountryCode = "SP", Level = "Easy", Name="Barcelona"},
                new Town{ CountryCode = "SP", Level = "Easy", Name="Malaga"},
                new Town{ CountryCode = "TN", Level = "Easy", Name="Hamamat"},
                new Town{ CountryCode = "TN", Level = "Easy", Name="Souse"},
                new Town{ CountryCode = "SA", Level = "Easy", Name="Mekkah"},
                new Town{ CountryCode = "SA", Level = "Easy", Name="Medinah"},
                new Town{ CountryCode = "US", Level = "Easy", Name="New York"},
                new Town{ CountryCode = "US", Level = "Easy", Name="Boston"},
                new Town{ CountryCode = "BE", Level = "Medium", Name="Anderlecht"},
                new Town{ CountryCode = "BE", Level = "Medium", Name="Liege"},
                new Town{ CountryCode = "NL", Level = "Medium", Name="Rotterdam"},
                new Town{ CountryCode = "NL", Level = "Medium", Name="Eindhoven"},
                new Town{ CountryCode = "EG", Level = "Medium", Name="Alexandria"},
                new Town{ CountryCode = "EG", Level = "Medium", Name="Mansoura"},
                new Town{ CountryCode = "CN", Level = "Medium", Name="Ganghzou"},
                new Town{ CountryCode = "CN", Level = "Medium", Name="Shanghai"},
                new Town{ CountryCode = "CH", Level = "Medium", Name="Geneva"},
                new Town{ CountryCode = "CH", Level = "Medium", Name="Zurich"},
                new Town{ CountryCode = "UK", Level = "Medium", Name="Manchester"},
                new Town{ CountryCode = "UK", Level = "Medium", Name="Liverpool"},
                new Town{ CountryCode = "CM", Level = "Hard", Name="Douala"},
                new Town{ CountryCode = "CM", Level = "Hard", Name="Bemenda"},
                new Town{ CountryCode = "AE", Level = "Hard", Name="Dubai"},
                new Town{ CountryCode = "AE", Level = "Hard", Name="Sharjah"},
                new Town{ CountryCode = "CO", Level = "Hard", Name="Medellin"},
                new Town{ CountryCode = "CO", Level = "Hard", Name="Cali"},
                new Town{ CountryCode = "PK", Level = "Hard", Name="Karachi"},
                new Town{ CountryCode = "PK", Level = "Hard", Name="Lahore"},
                new Town{ CountryCode = "SN", Level = "Hard", Name="Touba"},
                new Town{ CountryCode = "SN", Level = "Hard", Name="Pikine"},
                new Town{ CountryCode = "AR", Level = "Hard", Name="Rosario"},
                new Town{ CountryCode = "AR", Level = "Hard", Name="Mandoba"},

        };
        }

        public static GeoData Data { get; private set; }
    }
}
