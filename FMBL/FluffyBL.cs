using FMModels;
using System;
using System.Collections.Generic;
using FMDL;

namespace FMBL
{
    public class FluffyBL : IFluffyBL
    {
        private IFluffyRepo _repo;

        public string CreateUser(User user)
        {
            return null;
        }

        public User GetUserByName(string name)
        {
            return new User { UserId = 1, UserName = "asdf" };
        }
    }
}
