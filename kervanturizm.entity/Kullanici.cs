using kervanturizm.entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace kervanturizm.entity
{
    public class Kullanici
    {
        [Key]
        public int KullaniciID { get; set; }
        public string Mail { get; set; }
        public string Sifre { get; set; }

    }
}
