namespace E05BirthdayCelebrations
{
    public class Citizen : IIdentifiable, IBirthable
    {
        public Citizen( string name, int age, string id, string birhtdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birhtdate = birhtdate;
        }

        public string Id { get; set ; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Birhtdate { get; set; }
    }
}
