using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTutorial15Dey
{
    public class Country
    {
        public string countryName = "Iran";
        public string nationalLanguage = "Persian";
        public string nationality = "Iranian";
        public string nationalPhoneNoCode = "+98";
    }

    public class Tabriz : Country
    {
        public string dialect = "Torki";
        public string location = "NW";
    }

    public class Kermanshah : Country
    {
        public string dialect = "Kordi";
        public string location = "W";
    }
}
