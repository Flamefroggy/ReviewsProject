﻿using Microsoft.EntityFrameworkCore;
using ReviewsData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewsData.Service.Games
{
    public class GamesManager : IGamesManager
    {
        private IDbContextFactory<ReviewsDbContext> _contextFactory;
        public GamesManager(IDbContextFactory<ReviewsDbContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }
        public List<BaseEntity> Get()
        {
            using var db = _contextFactory.CreateDbContext();
            try
            {
                return db.Games.Cast<BaseEntity>().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Не удалось выполнить", ex);
            }
        }
    }
}
