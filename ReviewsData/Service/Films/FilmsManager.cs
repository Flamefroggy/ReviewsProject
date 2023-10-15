using Microsoft.EntityFrameworkCore;
using ReviewsData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewsData.Service.Games
{
    public class FilmsManager : IFilmsManager
    {
        private readonly IDbContextFactory<ReviewsDbContext> _contextFactory;
        public FilmsManager(IDbContextFactory<ReviewsDbContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }
        public List<BaseEntity> Get()
        {
            using var db = _contextFactory.CreateDbContext();
            try
            {
                return db.Films.Cast<BaseEntity>().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Не удалось выполнить", ex);
            }
        }
        
        public BaseEntity Create(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public BaseEntity Edit(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(BaseEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
