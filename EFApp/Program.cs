using EFApp.DataBase;

internal class Program
{
    private static EFAppDbContext? _context;

    private static void Main(string[] args)
    {
        _context = new EFAppDbContext();
        //_context.Database.EnsureCreated();

        //В цикле добавляем автомобили в БД
        for (int i = 0; i < 100; i++)
        {
            _context.Autos.Add(new AutoEntity
            {
                Id = new Guid(),
                Model = "A7",
                Name = "Audi",
                YearOfIssue = i,
                Country = "Germany",
                Price = 1500000
            });

            _context.SaveChanges();
        }

        Console.WriteLine("Нажмите для выхода");
        Console.ReadKey();
    }
}