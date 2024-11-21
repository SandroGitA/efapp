using EFApp.DataBase;

internal class Program
{
    private static EFAppDbContext? _context;

    private static void Main(string[] args)
    {
        _context = new EFAppDbContext();
        //_context.Database.EnsureCreated();
        //Генератор случаный чисел
        Random rndm = new Random();

        //В цикле добавляем автомобили в БД
        for (int i = 0; i < 7; i++)
        {
            var owner = new OwnerEntity()
            {
                Id = new Guid(),
                Name = "John",
                Age = 19
            };

            var auto = new AutoEntity()
            {
                Id = new Guid(),
                Name = "Audi",
                Model = "A7",
                YearOfIssue = rndm.Next(2015, 2024),
                Country = "Germany",
                Price = rndm.Next(2000000, 8500000),
                Owner = new OwnerEntity
                {
                    Id = new Guid(),
                    Name = "John",
                    Age = 19
                }
            };

            //_context.Owners.Add(owner);
            _context.Autos.Add(auto);

            _context.SaveChanges();
        }

        Console.WriteLine("Нажмите для выхода");
        Console.ReadKey();
    }
}