using StationEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationRepository.Repository
{
    class NotificationRepository : IRepository<Notification>, INotificationRepository<Notification>
    {
        public int Add(Notification entity)
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

        public List<Notification> GetAll()
        {
            throw new NotImplementedException();
        }

        public Notification GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public int Update(Notification entity)
        {
            throw new NotImplementedException();
        }
    }
}
