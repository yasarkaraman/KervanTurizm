using kervanturizm.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace kervanturizm.data.Abstract
{
    public interface ISehirRepository:IRepository<Sehir>
    {
        string sehirad();
 
    }
}
