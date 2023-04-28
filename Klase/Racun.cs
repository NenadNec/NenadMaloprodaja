using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maloprodaja.Klase
{
    public class Racun
    {
        public int Id { get; set; }
        public string BrojRacuna { get; set; }
        public int TipRacuna { get; set; }
        public int TipTransakcije { get; set; }
        public int TipPlacanja { get; set; }
        public DateTime DatumRacuna { get; set; }
        public int OperaterRefId { get; set; }
        public int MpRefId { get; set; }
        public List<StavkaRacuna> ListaStavki { get; set; }
    }
}
