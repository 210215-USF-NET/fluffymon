using FMModels;
using System;
using System.Collections.Generic;
using FMDL;

namespace FMBL
{
    public class FluffyBL : IFluffyBL
    {
        private IFluffyRepo _repo;


        public FluffyBL(IFluffyRepo repo)
        {
            _repo = repo; 
        }

        public Fluffymon AddFluffymons(Fluffymon newFluffymon)
        {
            return _repo.AddFluffymons(newFluffymon);
        }

        public void AddUser(User uName)
        {
            uName.UserHp = 100;
            _repo.AddUser(uName);
        }

        public UserFluffymon AddUserFluffymon(UserFluffymon newUFM)
        {
            return _repo.AddUserFluffymon(newUFM);
        }

        public List<Fluffymon> GetFluffymons()
        {
            return _repo.GetFluffymons();
        }

        public User GetUserByName(string name)
        {
            return _repo.GetUserByName(name);
        }

        public List<UserFluffymon> GetUserFluffymons()
        {
            return _repo.GetUserFluffymons();
        }

        public List<User> GetUsers()
        {
            return _repo.GetUsers();
        }
    }
}
