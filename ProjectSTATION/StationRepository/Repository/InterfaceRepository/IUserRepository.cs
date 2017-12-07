using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationRepository.Repository
{
    interface IUserRepository<TEntity>
    {
        TEntity SearchByUserName(string name);
        TEntity SearchByUserEmail(string email);
    }
}
