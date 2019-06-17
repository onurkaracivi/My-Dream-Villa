using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMyBed
{
    class OtelRezervasyon
    {
        public int OtelRezervasyonId { get; set; }
        public int VillaId { get; set; }
        public int RezervasyonId { get; set; }
        public DateTime GirişT { get; set; }
        public DateTime ÇıkışT { get; set; }
    }
}
