using FMModels;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
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
            _context.SaveChanges();
            return newFluffymon;
        }

        public User AddUser(User userName)
        {
            _context.Users.Add(userName);
            _context.SaveChanges();
            return userName;
        }

        public UserFluffymon AddUserFluffymon(UserFluffymon newUFM)
        {
            _context.UserFluffymons.Add(newUFM);
            _context.SaveChanges();
            return newUFM;
        }

        public List<Fluffymon> GetFluffymons()
        {
            return _context.Fluffymons.AsNoTracking().ToList();
        }

        public User GetUserByName(string name)
        {
            return _context.Users.Where(user => user.UserName.Equals(name)).AsNoTracking().FirstOrDefault();
        }

        public List<UserFluffymon> GetUserFluffymons()
        {
            return _context.UserFluffymons.Include("Fluffymon").AsNoTracking().ToList();
        }

        public List<User> GetUsers()
        {
            return _context.Users.AsNoTracking().ToList();
        }
    }
}
