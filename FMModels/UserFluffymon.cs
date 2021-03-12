namespace FMModels
{
    public class UserFluffymon
    {
        public int UserFluffymonId { get; set; }
        public int FluffymonId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public Fluffymon Fluffymon { get; set; }
    }
}
