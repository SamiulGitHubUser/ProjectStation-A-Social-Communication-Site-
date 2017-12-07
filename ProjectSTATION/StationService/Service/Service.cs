using StationEntity;
using StationRepository;
using StationRepository.Repository;
using StationRepository.Repository.ImplementRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationService
{
    public class Service<TEntity> : IService<TEntity> where TEntity : Entity
    {
        IRepository<TEntity> repo = new Repository<TEntity>();

        public int Add(TEntity entity)
        {
            return repo.Add(entity);
            //throw new NotImplementedException();
        }

        public int DeleteByID(int id)
        {
            return repo.DeleteByID(id);
            //throw new NotImplementedException();
        }

        public int DeleteByName(string name)
        {
            return repo.DeleteByName(name);
            //throw new NotImplementedException();
        }

        public List<TEntity> GetAll()
        {
            return repo.GetAll();
            //throw new NotImplementedException();
        }

        public TEntity GetByID(int id)
        {
            return repo.GetByID(id);
            //throw new NotImplementedException();
        }

        public int Update(TEntity entity)
        {
            return repo.Update(entity);
            //throw new NotImplementedException();
        }
    }
}
