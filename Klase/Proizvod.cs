using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maloprodaja.Klase
{
    public class Proizvod
    {
        public int id { get; set; }
        public string nazivProizvoda { get; set; }
        public string sifraProizvoda { get; set; }
        public string poreskaLabela { get; set; }
        public string napomena { get; set; }
        public double cena { get; set; }
        public double kolicina { get; set; }
        public double poreskaStopa { get; set; }
    }
}
