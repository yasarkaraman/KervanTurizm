using kervanturizm.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kervanturizm.webui.Models
{
    public class BiletGuzergah
    {
        public List<kervanturizm.entity.Bilet> Bilets { get; set; }
        public List<Guzergah> Guzergahs { get; set; }
        public List<Sehir> Sehirs { get; set; }

        public Guzergah YeniGuzergah { get; set; }

        public Guzergah GuzergahID { get; set; }
        public string tarih { get; set; }
        public string saat { get; set; }
        public Guzergah gz1 { get; set; }

        public Guzergah gz2 { get; set; }
        public Guzergah gz3 { get; set; }
        public Guzergah Baslangic { get; set; }
        public Guzergah Bitis { get; set; }

        public Bilet bilet { get; set; }

    }
}
