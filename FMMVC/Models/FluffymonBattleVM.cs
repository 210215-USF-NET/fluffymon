using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FMModels;

namespace FMMVC.Models
{
    public class FluffymonBattleVM
    {
        public int FluffymonId { get; set; }
        public int Fluffiness { get; set; }
        public string FluffymonName { get; set; }
        public int AES { get; set; }
        public int MGTR { get; set; }
        public Element Element { get; set; }
        public List<UserFluffymon> UserFluffymon { get; set; }
    }
}
