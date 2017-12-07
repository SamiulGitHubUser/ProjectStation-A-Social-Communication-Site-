using StationEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationRepository.Repository
{
    class UserProfileRepository : IRepository<UserProfile>, IUserProfileRepository<UserProfile>
    {
        public int Add(UserProfile entity)
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

        public List<UserProfile> GetAll()
        {
            throw new NotImplementedException();
        }

        public UserProfile GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public int SearchByFirstName(string f_Name)
        {
            throw new NotImplementedException();
        }

        public int SearchByLastName(string l_Name)
        {
            throw new NotImplementedException();
        }

        public int Update(UserProfile entity)
        {
            throw new NotImplementedException();
        }
    }
}
