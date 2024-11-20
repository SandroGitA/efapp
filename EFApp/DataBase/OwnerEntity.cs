namespace EFApp.DataBase
{
    public class OwnerEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public List<AutoEntity> Autos { get; set; } = new();
    }
}
