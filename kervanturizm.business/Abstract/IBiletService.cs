using kervanturizm.entity;
using kervanturizm.data;
using kervanturizm.business;
using System;
using System.Collections.Generic;
using System.Text;

namespace kervanturizm.business.Abstract
{
    public interface IBiletService
    {
        Bilet GetById(int id);
        void Create(Bilet entity);
        void Update(Bilet entity);
        void Delete(Bilet entity);
        void Update(Bilet entity, int[] BiletIDs);
        List<Bilet> GetAll();
        int GetCountByKoltuk(int GuzergahID);
        List<int> GetKoltuk(int GuzergahID);
        Bilet GetSonKayit();
        int GetId();
        string Gettarih(int id);
        string Getsaat(int id);
    }
}
    