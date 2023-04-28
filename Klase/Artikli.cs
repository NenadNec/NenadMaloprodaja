using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maloprodaja.Klase
{
    public class Artikal
    {
        public int Id { get; set; }
        public string NazivArtikla { get; set; }
        public string JedinicaMere { get; set; }
        public string GTIN { get; set; }
        public string Sifra { get; set; }
        public decimal Cena { get; set; }
        public string VrstaArtikla { get; set; }
       
    }
}
