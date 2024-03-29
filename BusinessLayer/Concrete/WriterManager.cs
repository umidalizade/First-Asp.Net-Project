﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WriterManager : IWriterService
    {
        IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public List<Writer> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Writer> GetWriterById(int id)
        {
            return _writerDal.GetListAll(x=>x.WriterId == id);
        }

        public void TAdd(Writer t)
        {
            _writerDal.Insert(t);
        }

        public Writer TGetById(int id)
        {
            return _writerDal.GetTById(id);
        }

        public void TRemove(Writer t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Writer t)
        {
            _writerDal.Update(t);
        }

        //public void WriterAdd(Writer writer)
        //{
        //    _writerDal.Insert(writer);
        //}
    }
}
