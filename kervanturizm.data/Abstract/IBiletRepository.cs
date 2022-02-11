using kervanturizm.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace kervanturizm.data.Abstract
{
    public interface IBiletRepository:IRepository<Bilet>
    {
        int GetCountByKoltuk(int GuzergahID);
        List<int> GetKoltuk(int GuzergahID);
        Bilet GetSonKayit();
        int GetId();
        string Gettarih(int id);
        string Getsaat(int id);
    }
}
