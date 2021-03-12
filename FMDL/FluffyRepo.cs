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
            _context.Fluffymons.Add(newFluffymon);
            return newFluffymon;
        }

        public User AddUser(User userName)
        {
            _context.Users.Add(userName);
            return userName;
        }

        public UserFluffymon AddUserFluffymon(UserFluffymon newUFM)
        {
            _context.UserFluffymons.Add(newUFM);
            return newUFM;
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
