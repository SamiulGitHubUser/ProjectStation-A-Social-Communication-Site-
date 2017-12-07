using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationRepository.Repository
{
    interface IUserProfileRepository<TEntity>
    {
        int SearchByFirstName(string f_Name);
        int SearchByLastName(string l_Name);
    }
}
