using System.Collections.Generic;

namespace FMModels
{
    public class Fluffymon
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
