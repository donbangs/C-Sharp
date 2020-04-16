using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osooba
{
    public class Osoba 
    {

        public string Name { get; set; }

        public string Surname { get; set; }

        public int Year { get; set; }

        public string City { get; set; }

        public Uri Photo { get; set; }

        public Osoba(string Name, string Surname, string City, int Year)
        { 
            this.Name = Name;
            this.Surname = Surname;
            this.Year = Year;
            this.City = City;
           
        }

      
       

      
    }
}
