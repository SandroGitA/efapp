namespace EFApp.DataBase
{
    public class AutoEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public int YearOfIssue { get; set; }
        public string Country { get; set; }
        public long Price { get; set; }

        //public Guid OwnerId { get; set; }
        //public OwnerEntity? Owner { get; set; }
    }
}
