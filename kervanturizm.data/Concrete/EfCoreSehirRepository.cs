using kervanturizm.data.Abstract;
using kervanturizm.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace kervanturizm.data.Concrete
{
    public class EfCoreSehirRepository : EfCoreGenericRepository<Sehir, BiletContext>, ISehirRepository
    {
        public string sehirad()
        {
            throw new NotImplementedException();
        }
    }
}
