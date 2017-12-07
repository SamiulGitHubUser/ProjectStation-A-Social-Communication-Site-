using StationEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationRepository.Repository
{
    class SenderRepository : IRepository<Sender>, ISenderRepository<Sender>
    {
        public int Add(Sender entity)
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

        public List<Sender> GetAll()
        {
            throw new NotImplementedException();
        }

        public Sender GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public int Update(Sender entity)
        {
            throw new NotImplementedException();
        }
    }
}
