using EFApp.DataBase;

internal class Program
{
    private static EFAppDbContext? _context;

    private static void Main(string[] args)
    {
        _context = new EFAppDbContext();
        //_context.Database.EnsureCreated();
        //Генератор случаный чисел
        Random rnd = new Random();

        //В цикле добавляем автомобили в БД
        for (int i = 0; i < 7; i++)
        {
            _context.Autos.Add(new AutoEntity
            {
                Id = new Guid(),
                Name = "Audi",
                Model = "A7",
                YearOfIssue = rnd.Next(2015, 2024),
                Country = "Germany",
                Price = rnd.Next(2000000, 8500000)
            });

            _context.Owners.Add(new OwnerEntity
            {
                Id = new Guid(),
                Name = "John",
                Age = 19
            });

            _context.SaveChanges();
        }

        Console.WriteLine("Нажмите для выхода");
        Console.ReadKey();
    }
}