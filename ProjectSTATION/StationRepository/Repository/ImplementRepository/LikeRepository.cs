using StationEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationRepository.Repository
{
    class LikeRepository : IRepository<Like>, ILikeRepository<Like>
    {
        public int Add(Like entity)
        {
            throw new NotImplementedException();
        }

        public int DeleteByID(int id)
        {
            throw new NotImplementedException();
        }

        public int DeleteByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<Like> GetAll()
        {
            throw new NotImplementedException();
        }

        public Like GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public int Update(Like entity)
        {
            throw new NotImplementedException();
        }
    }
}
