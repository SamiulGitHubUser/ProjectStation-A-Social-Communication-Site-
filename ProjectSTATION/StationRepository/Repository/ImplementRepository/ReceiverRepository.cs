using StationEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationRepository.Repository
{
    class ReceiverRepository : IRepository<Receiver>, IReceiverRepository<Receiver>
    {
        public int Add(Receiver entity)
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

        public List<Receiver> GetAll()
        {
            throw new NotImplementedException();
        }

        public Receiver GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public int Update(Receiver entity)
        {
            throw new NotImplementedException();
        }
    }
}
