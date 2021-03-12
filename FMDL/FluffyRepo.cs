using FMModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMDL
{
    public class FluffyRepo : IFluffyRepo
    {
        private readonly FluffyDBContext _context;
        public FluffyRepo(FluffyDBContext context)
        {
            _context = context;
        }
        public Fluffymon AddFluffymons(Fluffymon newFluffymon)
        {
            throw new NotImplementedException();
        }

        public User AddUser(User userName)
        {
            throw new NotImplementedException();
        }

        public UserFluffymon AddUserFluffymon(UserFluffymon newUFM)
        {
            throw new NotImplementedException();
        }

        public List<Element> GetElements()
        {
            throw new NotImplementedException();
        }

        public List<Fluffymon> GetFluffymons()
        {
            throw new NotImplementedException();
        }

        public User GetUserByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<UserFluffymon> GetUserFluffymons()
        {
            throw new NotImplementedException();
        }

        public List<User> GetUsers()
        {
            throw new NotImplementedException();
        }
    }
}
