using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMyBed
{
    class Rezervasyon
    {
        public int Id { get; set; }
        public DateTime GirişTarihi { get; set; }
        public DateTime ÇıkışTarihi { get; set; }
        public int BölgeId { get; set; }
        public decimal Ücret { get; set; }
        public int VillaId { get; set; }
        public int MisafirId { get; set; }
    }
}
