using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace kervanturizm.entity
{
    public class Guzergah
    {
        [Key]
        public int GuzergahID { get; set; }
        public string Baslangic { get; set; }
        public string gz1 { get; set; }
        public string gz2 { get; set; }
        public string gz3 { get; set; }
        public string Bitis { get; set; }
        public string tarih { get; set; }
        public string saat { get; set; }
        public double Fiyat { get; set; }
        public string ImageUrl { get; set; }
        public List<Bilet> Bilets { get; set; }
    }
}
