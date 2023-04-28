using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maloprodaja.Klase
{
    public class StavkaPorudzbenice
    {
        public int Id { get; set; }
        public int ArtikalRefId { get; set; }
        public string ArtikalNaziv { get; set; }
        public decimal Kolicina { get; set; }
        public string Napomena { get; set; }
    }
}
