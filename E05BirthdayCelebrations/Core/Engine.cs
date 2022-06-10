using System;
using System.Collections.Generic;
using System.Linq;

namespace E05BirthdayCelebrations
{
    public class Engine
    {
        private List<IBirthable> dBase;

        public Engine()
        {
            this.dBase = new List<IBirthable>();
        }

        public void Run()
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] tokens = input.Split();
                CreateIdentifier(tokens);

                input = Console.ReadLine();
            }

            string birthYear = Console.ReadLine();
            string[] birthdays = dBase.Where(b => b.Birhtdate.Split('/').Last() == birthYear)
                .Select(b => b.Birhtdate).ToArray();
            //string[] birthdays = dBase.Where(i => i.Birhtdate.EndsWith(birthYear))
            //    .Select(i => i.Birhtdate).ToArray();
            PrintFakes(birthdays);
        }

        private void PrintFakes(string[] birthdays)
        {
            Console.WriteLine(string.Join(Environment.NewLine, birthdays));
        }

        private void CreateIdentifier(string[] tokens)
        {
            IBirthable birthable = null;

            string type = tokens[0];

            if (type == "Citizen")
            {
                string name = tokens[1];
                int age = int.Parse(tokens[2]);
                string id = tokens[3];
                string birthdate = tokens[4];
                birthable = new Citizen(name, age, id, birthdate);
            }
            else if (type == "Pet")
            {
                string name = tokens[1];
                string birhtdate = tokens[2];
                birthable = new Pet(name, birhtdate);
            }

            if (birthable != null)
            {
                this.dBase.Add(birthable);

            }
        }
    }
}
