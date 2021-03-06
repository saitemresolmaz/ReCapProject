﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    // T referans class olmalı, IEntityden newlenebilir olmalı
    public interface IEntityRepository<T> where T : class, IEntity, new() 
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null); //expression filter yazmamızı sağlar.
        T Get(Expression<Func<T, bool>> filter); //filter vermiyorsa tüm datayı ister.
        //List<T> GetById(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
