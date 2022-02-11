using kervanturizm.data.Abstract;
using kervanturizm.entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kervanturizm.data.Concrete
{
    public class EfCoreBiletRepository : EfCoreGenericRepository<Bilet, BiletContext>, IBiletRepository
    {
        public int GetCountByKoltuk(int GuzergahID)
        {
            using (var context = new BiletContext())
            {
                return context.Bilets
                    .Where(i => i.GuzergahID == GuzergahID)
                    .Select(i => i.KoltukNo)
                    .Count();
            }
        }

        public List<int> GetKoltuk(int GuzergahID)
        {
            using (var context = new BiletContext())
            {
                var koltuk = context.Bilets
                    .Where(i => i.GuzergahID == GuzergahID)
                    .Select(i => i.KoltukNo)
                    .ToList();

                return koltuk;
            }
        }

        public string Getsaat()
        {
            throw new NotImplementedException();
        }

        public Bilet GetSonKayit()
        {
            using(var context=new BiletContext())
            {
                var sonbilet = context.Bilets
                    .OrderByDescending(i => i.BiletID)
                    .FirstOrDefault();
                return sonbilet;
            }
        }

        public int GetId()
        {
            using (var context = new BiletContext())
            {
                var id = context.Bilets
                    .OrderByDescending(i => i.BiletID)
                    .Select(i => i.GuzergahID)
                    .FirstOrDefault();
                return id;
            }
        }

        public string Gettarih(int id)
        {
            using (var context = new BiletContext())
            {
                var sonbilettarih = context.Guzergahs
                    .Where(i => i.GuzergahID == id)
                    .Select(i => i.tarih)
                    .FirstOrDefault();
                    
                return sonbilettarih;
            }
        }

        public string Getsaat(int id)
        {
            using (var context = new BiletContext())
            {
                var sonbiletsaat = context.Guzergahs
                    .Where(i => i.GuzergahID == id)
                    .Select(i => i.saat)
                    .FirstOrDefault();

                return sonbiletsaat;
            }
        }
    }
}
