using StationEntity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationRepository.Repository.ImplementRepository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        StationDBContext dbCon = new StationDBContext();

        public int Add(TEntity entity)
        {
            dbCon.Set<TEntity>().Add(entity);
            return dbCon.SaveChanges();
            //throw new NotImplementedException();
        }

        public int DeleteByID(int id)
        {
            User userToDelete = dbCon.Users.SingleOrDefault(u => u.ID == id);
            dbCon.Users.Remove(userToDelete);
            return dbCon.SaveChanges();
            //throw new NotImplementedException();
        }

        public int DeleteByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetAll()
        {
            return dbCon.Set<TEntity>().ToList();
            //throw new NotImplementedException();
        }

        public TEntity GetByID(int id)
        {
            return dbCon.Set<TEntity>().Find(id);
            //throw new NotImplementedException();
        }

        public int Update(TEntity entity)
        {
            dbCon.Entry<TEntity>(entity).State= EntityState.Modified;
            return dbCon.SaveChanges();
            //throw new NotImplementedException();
        }
    }
}
