using StationEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationRepository.Repository.ImplementRepository
{
    class LoginRepository : IRepository<Login> , ILoginRepository<Login>
    {
        public int Add(Login entity)
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

        public List<Login> GetAll()
        {
            throw new NotImplementedException();
        }

        public Login GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public int Update(Login entity)
        {
            throw new NotImplementedException();
        }
    }
}
