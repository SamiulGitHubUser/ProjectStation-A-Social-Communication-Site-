using StationEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationRepository.Repository
{
    class CommentRepository : IRepository<Comment>, ICommentRepository<Comment>
    {
        public int Add(Comment entity)
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

        public List<Comment> GetAll()
        {
            throw new NotImplementedException();
        }

        public Comment GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public int Update(Comment entity)
        {
            throw new NotImplementedException();
        }
    }
}
