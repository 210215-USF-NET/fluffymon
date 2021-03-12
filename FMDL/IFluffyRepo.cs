using System.Collections.Generic;
using FMModels;


namespace FMDL
{
    public interface IFluffyRepo
    {
        List<User> GetUsers();
        User AddUser(User userName);
        User GetUserByName(string name);
        List<Element> GetElements();
        List<Fluffymon> GetFluffymons();
        List<UserFluffymon> GetUserFluffymons();
        Fluffymon AddFluffymons(Fluffymon newFluffymon);
        UserFluffymon AddUserFluffymon(UserFluffymon newUFM);
    }
}
