﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCash_proje_Edenyity.BusinessLayer.Abstrack
{
   public interface IGenericService<T> where T : class
    {
        void TInsert(T t);
        void TUpdate(T t);
        void TDelete(T t);
        T TGetById(int id);
        List<T> TGetAll();
    }
}