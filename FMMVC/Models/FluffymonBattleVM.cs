using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using FMModels;

namespace FMMVC.Models
{
    public class FluffymonBattleVM
    {
        public int FluffymonId { get; set; }
        [DisplayName("Fluffiness")]
        public int Fluffiness { get; set; }
        [DisplayName("Fluffymon")]
        public string FluffymonName { get; set; }
        [DisplayName("Anime Eye Size")]
        public int AES { get; set; }
        [DisplayName("Transformation Time")]
        public int MGTR { get; set; }
        public Element Element { get; set; }
        public List<UserFluffymon> UserFluffymon { get; set; }
    }
}
