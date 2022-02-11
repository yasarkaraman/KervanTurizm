using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace kervanturizm.entity
{
    public class Bilet
    {
        [Key]
        public int BiletID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Mail { get; set; }
        public string Nereden { get; set; }
        public string Nereye { get; set; }
        public int KoltukNo { get; set; }
        public double Fiyat { get; set; }
        public Guzergah guzergah { get; set; }
        public int GuzergahID { get; set; }
    }
}

