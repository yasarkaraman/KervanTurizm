using kervanturizm.business.Abstract;
using kervanturizm.data.Abstract;
using kervanturizm.business.Concrete;
using kervanturizm.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace kervanturizm.business.Concrete
{
    public class BiletManager: IBiletService
    {
        private IBiletRepository _biletRepository;
        public BiletManager(IBiletRepository biletRepository)
        {
            _biletRepository = biletRepository;
        }

        public void Create(Bilet entity)
        {
            _biletRepository.Create(entity);
        }

        public void Delete(Bilet entity)
        {
            _biletRepository.Delete(entity);
        }

        public List<Bilet> GetAll()
        {
            return _biletRepository.GetAll();
        }

        public Bilet GetById(int id)
        {
            return _biletRepository.GetById(id);
        }

        public int GetCountByKoltuk(int GuzergahID)
        {
            return _biletRepository.GetCountByKoltuk(GuzergahID);
        }

        public int GetId()
        {
            return _biletRepository.GetId();
        }

        public List<int> GetKoltuk(int GuzergahID)
        {
            return _biletRepository.GetKoltuk(GuzergahID);
        }

        public string Getsaat(int id)
        {
            return _biletRepository.Getsaat(id);
        }

        public Bilet GetSonKayit()
        {
            return _biletRepository.GetSonKayit();
        }

        public string Gettarih(int id)
        {
            return _biletRepository.Gettarih(id);
        }

        public void Update(Bilet entity)
        {
            _biletRepository.Update(entity);
        }

        public void Update(Bilet entity, int[] BiletIDs)
        {
            throw new NotImplementedException();
        }
    }
}
