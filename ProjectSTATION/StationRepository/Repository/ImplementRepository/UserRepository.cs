using StationEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationRepository.Repository
{
    class UserRepository : IRepository<User>, IUserRepository<User>
    {
        StationDBContext dbCon = new StationDBContext();

        //UserAdd
        public int Add(User entity)
        {
            dbCon.Users.Add(entity);
            return dbCon.SaveChanges();
            //throw new NotImplementedException();
        }
        
        //UserDeleteBy(ID)
        public int DeleteByID(int id)
        {
            User userToDelete = dbCon.Users.SingleOrDefault(u => u.ID == id);
            dbCon.Users.Remove(userToDelete);
            return dbCon.SaveChanges();
            //throw new NotImplementedException();
        }

        //UserDeleteBy(Name)
        public int DeleteByName(string name)
        {
            User userToDelete = dbCon.Users.SingleOrDefault(u => u.UserName == name);
            dbCon.Users.Remove(userToDelete);
            return dbCon.SaveChanges();
            //throw new NotImplementedException();
        }

        //GetAllUser
        public List<User> GetAll()
        {
            var results = from c in dbCon.Users select c;
            return results.ToList();
            //throw new NotImplementedException();
        }

        //GetOneUser
        public User GetByID(int id)
        {
            User user = dbCon.Users.SingleOrDefault(u => u.ID == id);
            return user;
            //throw new NotImplementedException();
        }

        //GetByEmail
        public User SearchByUserEmail(string email)
        {
            User user = dbCon.Users.SingleOrDefault(u => u.UserEmail == email);
            return user;
            //throw new NotImplementedException();
        }

        //GetByUserName
        public User SearchByUserName(string name)
        {
            User user = dbCon.Users.SingleOrDefault(u => u.UserName == name);
            return user;
            //throw new NotImplementedException();
        }

        //UserUpdate
        public int Update(User entity)
        {
            User userUpdate = dbCon.Users.SingleOrDefault(d => d.UserName == entity.UserName);
            userUpdate.UserEmail = entity.UserEmail;
            userUpdate.Password = entity.Password;
            userUpdate.UserType = entity.UserType;
            
            return dbCon.SaveChanges();
            //throw new NotImplementedException();
        }
    }
}
