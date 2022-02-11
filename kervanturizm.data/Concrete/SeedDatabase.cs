using kervanturizm.entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kervanturizm.data.Concrete
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new BiletContext();
            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Guzergahs.Count() == 0)
                {
                    context.Guzergahs.AddRange(Guzergahs);
                }


                if (context.Bilets.Count() == 0)
                {
                    context.Bilets.AddRange(Bilets);
                    
                }
                if (context.Sehirs.Count() == 0)
                {
                    context.Sehirs.AddRange(Sehirs);

                }
                if (context.Admins.Count() == 0)
                {
                    context.Admins.AddRange(Admins);

                }
                if (context.Kullanicis.Count() == 0)
                {
                    context.Kullanicis.AddRange(Kullanicis);

                }

                context.SaveChanges();
            }
        }

        private static Guzergah[] Guzergahs =
        {
            new Guzergah(){ GuzergahID=1, Baslangic="İstanbul", gz1="Kocaeli", gz2="Kütahya", gz3="Afyon", Bitis="Isparta", tarih="15.05.2021", saat="18.00", ImageUrl="1.jpg", Fiyat=110},
            new Guzergah(){ GuzergahID=2, Baslangic="Rize", gz1="Ordu", gz2="Samsun", gz3="Kocaeli", Bitis="İstanbul", tarih="16.05.2021", saat="19.00", ImageUrl="3.jpg", Fiyat=180},
            };

        private static Bilet[] Bilets =
        {
            new Bilet(){BiletID=1, Ad="Emirhan", Soyad="Taşçı", Mail="emirhantasci@outlook.com", Nereden="İstanbul", Nereye="Isparta", KoltukNo=11, Fiyat=110, GuzergahID=1},
            new Bilet(){BiletID=2, Ad="Can", Soyad="Yumak", Mail="canyumak@outlook.com", Nereden="Kocaeli", Nereye="Isparta", KoltukNo=10, Fiyat=100, GuzergahID=1},
            new Bilet(){BiletID=3, Ad="Hale", Soyad="Opak", Mail="haleopak@outlook.com", Nereden="Kütahya", Nereye="Isparta", KoltukNo=8, Fiyat=80, GuzergahID=1},
            new Bilet(){BiletID=4, Ad="Aylin", Soyad="Kone", Mail="aylinkone@outlook.com", Nereden="İstanbul", Nereye="Isparta", KoltukNo=4, Fiyat=110, GuzergahID=1},
            new Bilet(){BiletID=5, Ad="Murat", Soyad="Porut", Mail="muratporut@outlook.com", Nereden="İstanbul", Nereye="Isparta", KoltukNo=20, Fiyat=110, GuzergahID=1},
            new Bilet(){BiletID=6, Ad="Mehmet", Soyad="Oguz", Mail="mehmetoguz@outlook.com", Nereden="İstanbul", Nereye="Isparta", KoltukNo=19, Fiyat=110, GuzergahID=1},
            new Bilet(){BiletID=7, Ad="Yusuf", Soyad="Süy", Mail="yusufyus@outlook.com", Nereden="Rize", Nereye="İstanbul", KoltukNo=15, Fiyat=180, GuzergahID=2},
            new Bilet(){BiletID=8, Ad="Sena", Soyad="Çor", Mail="senacor@outlook.com", Nereden="Ordu", Nereye="Samsun", KoltukNo=11, Fiyat=60, GuzergahID=2},
            new Bilet(){BiletID=9, Ad="Ahmet", Soyad="Can", Mail="ahmetcan@outlook.com", Nereden="Kocaeli", Nereye="İstanbul", KoltukNo=8, Fiyat=50, GuzergahID=2}
            
        };
        private static Sehir[] Sehirs =
        {
            new Sehir(){ SehirID=1, SehirAd= "İstanbul"},
            new Sehir(){ SehirID=2, SehirAd= "Kocaeli"},
            new Sehir(){ SehirID=3, SehirAd= "Kütahya"},
            new Sehir(){ SehirID=4, SehirAd= "Afyon"},
            new Sehir(){ SehirID=5, SehirAd= "Isparta"},
            
            new Sehir(){ SehirID=6, SehirAd= "Samsun"},
            new Sehir(){ SehirID=7, SehirAd= "Ordu"},
            new Sehir(){ SehirID=8, SehirAd= "Rize"}
        };
        private static Kullanici[] Kullanicis =
        {



        };
        private static Admin[] Admins=
        {



        };


    }
}
