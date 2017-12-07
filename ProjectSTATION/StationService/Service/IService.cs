using StationEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationService
{
    public interface IService<TEntity> where TEntity : Entity
    {
        int Add(TEntity entity);
        int Update(TEntity entity);
        int DeleteByName(string name);
        int DeleteByID(int id);
        TEntity GetByID(int id);

        List<TEntity> GetAll();
    }
}
