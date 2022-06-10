using System;
using System.Collections.Generic;
using System.Linq;

namespace E06FoodShortage
{
    public class Engine
    {
        private List<IBuyer> dBase;

        public Engine()
        {
            this.dBase = new List<IBuyer>();
        }

        public void Run()
        {
            int n = int.Parse(Console.ReadLine());
            FilldBase(n);

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] tokens = input.Split();
                CreateIdentifier(tokens);

                input = Console.ReadLine();
            }

            //string birthYear = Console.ReadLine();
            // string[] birthdays = dBase.Where(b => b.Birhtdate.Split('/').Last() == birthYear)
            //   .Select(b => b.Birhtdate).ToArray();
            //string[] birthdays = dBase.Where(i => i.Birhtdate.EndsWith(birthYear))
            //    .Select(i => i.Birhtdate).ToArray();
            //PrintFakes(birthdays);
        }

        private void FilldBase(int n)
        {
            for (int i = 0; i < n; i++)
            {
                string[] buyersInfo = Console.ReadLine().Split();
                string name = buyersInfo[0];
                int age = int.Parse(buyersInfo[1]);
                IBuyer buyer = null;

                if (buyersInfo.Length == 3)
                {
                    string group = buyersInfo[2];
                    buyer = new Rebel(name, age, group);
                }
                else if (buyersInfo.Length == 4)
                {
                    string id = buyersInfo[2];
                    string birthdate = buyersInfo[3];
                    buyer = new Citizen(name, age, id, birthdate);
                }

                if (buyer != null)
                {
                    dBase.Add(buyer);
                }
            }
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
