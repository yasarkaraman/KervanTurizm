using kervanturizm.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace kervanturizm.business.Abstract
{
    public interface ISehirService
    {
        Sehir GetById(int id);
        string sehirad();
        void Create(Sehir entity);
        void Update(Sehir entity);
        void Delete(Sehir entity);
        void Update(Sehir entity, int[] SehirIDs);
        List<Sehir> GetAll();
    }
}
