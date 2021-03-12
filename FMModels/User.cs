using System.Collections.Generic;

namespace FMModels
{
    public class User
    {
        public int UserId { get; set; }
        public int UserHp { get; set; }
        public string UserName { get; set; }
        public List<Fluffymon> Fluffymon { get; set; }
    }
}
