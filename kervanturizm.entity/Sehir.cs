using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace kervanturizm.entity
{
       public class Sehir
    {[Key]
        public int SehirID { get; set; }
        public string SehirAd { get; set; }
        
    }
}

