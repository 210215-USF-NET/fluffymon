using FMModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace FMMVC.Models
{
    public class UserBattleVM
    {
        public int UserId { get; set; }
        [DisplayName("HP")]
        public int UserHp { get; set; }
        [DisplayName("Name")]
        public string UserName { get; set; }
        public List<Fluffymon> Fluffymon { get; set; }
    }
}
