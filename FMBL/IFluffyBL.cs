using FMModels;
using System;
using System.Collections.Generic;
using System.Text;
using FMModels;

namespace FMBL
{
    public interface IFluffyBL
    {
        List<User> GetUsers();
        void AddUser(User uName);
        User GetUserByName(string name);
        List<Fluffymon> GetFluffymons();
        List<UserFluffymon> GetUserFluffymons();
        Fluffymon AddFluffymons(Fluffymon newFluffymon);
        UserFluffymon AddUserFluffymon(UserFluffymon newUFM);
    }
}
