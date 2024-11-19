namespace EFApp.Core
{
    //Класс автомобиля
    public class Auto
    {
        //ID автомобиля
        public Guid Id { get; set; }

        //Название автомобиля
        public string Name { get; set; }

        //Модель автомобиля
        public string Model { get; set; }

        //Год выпуска автомобиля
        public int YearOfIssue { get; set; }

        //Конструктор
        public Auto(Guid id, string name, string model, int year)
        {
            Id = id;
            Name = name;
            Model = model;
            YearOfIssue = year;
        }

        //Метод для создания автомобиля
        public static Auto CreateAuto(Guid id, string name, string model, int year)
        {
            return new Auto(id, name, model, year);
        }
    }
}
