﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoAspNet.Domain
{
    public interface IRepository<TEntity>
    {
        TEntity GetById(int id);
        void Save(TEntity entity);
        IEnumerable<TEntity> All();
    }
}
