using StationEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationRepository.Repository
{
    class FollowingRepository : IRepository<Followship>, IFollowshipRepository<Followship>
    {
        public int Add(Followship entity)
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

        public List<Followship> GetAll()
        {
            throw new NotImplementedException();
        }

        public Followship GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public int Update(Followship entity)
        {
            throw new NotImplementedException();
        }
    }
}
