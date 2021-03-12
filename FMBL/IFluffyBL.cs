using FMModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FMBL
{
    public interface IFluffyBL
    {
        public string CreateUser(User user);
        public User GetUserByName(string name);
    }
}
