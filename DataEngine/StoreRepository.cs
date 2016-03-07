﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataEngine.Contexts;
using DataEngine.Entities;
using DataEngine.RepositoryCore;
using NHibernate.Linq;

namespace DataEngine
{
    public class StoreRepository<T> : Repository<T> where T : Store
    {
        public StoreRepository(ISessionContext sessionContext) : base(sessionContext)
        {
            AllowLocalEdits = false;
        }

        public IList<Store> GetWithName(string name)
        {
            var query = SessionContext.Session.QueryOver<Store>().Where(x => x.StoreName == name).List();
            IList<Store> stores = query;

            return stores;
        }
    }
}
