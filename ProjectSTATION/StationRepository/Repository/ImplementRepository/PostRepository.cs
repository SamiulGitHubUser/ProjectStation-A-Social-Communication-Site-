using StationEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationRepository.Repository
{
    class PostRepository : IRepository<Post>, IPostRepository<Post>
    {
        public int Add(Post entity)
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

        public List<Post> GetAll()
        {
            throw new NotImplementedException();
        }

        public Post GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public int Update(Post entity)
        {
            throw new NotImplementedException();
        }
    }
}
