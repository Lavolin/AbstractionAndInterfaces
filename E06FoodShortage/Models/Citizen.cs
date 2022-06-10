namespace E06FoodShortage
{
    public class Citizen : IIdentifiable, IBirthable, IBuyer
    {
        public Citizen( string name, int age, string id, string birhtdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birhtdate = birhtdate;
            
        }

        public string Id { get; set ; }
        public string Name { get; private set; }
        public int Food { get; private set; }
        public int Age { get; set; }
        public string Birhtdate { get; set; }


        public void BuyFood()
        {
            this.Food += 10;
        }
    }
}
