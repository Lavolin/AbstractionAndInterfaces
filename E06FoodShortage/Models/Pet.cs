namespace E06FoodShortage
{
    public class Pet : IBirthable
    {
        public Pet(string name, string birhtdate)
        {
            Name = name;
            Birhtdate = birhtdate;
        }

        public string Name { get; set; }
        public string Birhtdate { get ; set ; }

    }
}
