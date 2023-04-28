using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maloprodaja.Klase
{
    public class PorudzbenicaClass
    {
        public int Id { get; set; }
        public string BrojPorudzbenice { get; set; }
        public DateTime DatumPorudzbenice { get; set; }
        public string Porucilac { get; set; }
        public string Telefon { get; set; }
        public DateTime DatumIsporuke { get; set; }
        public string Napomena { get; set; }
        public List<StavkaPorudzbenice> ListaStavki { get; set; }
    }
}
