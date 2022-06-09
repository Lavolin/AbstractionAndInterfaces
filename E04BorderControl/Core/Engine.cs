using System;
using System.Collections.Generic;
using System.Linq;

namespace E04BorderControl
{
    public class Engine
    {
        private List<IIdentifiable> dbBase;

        public Engine()
        {
            this.dbBase = new List<IIdentifiable>();
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

            string fakePattern = Console.ReadLine();
            string[] fakeIds = dbBase.Where(i => i.Id.EndsWith(fakePattern))
                .Select(i => i.Id).ToArray();

            PrintFakes(fakeIds);
        }

        private void PrintFakes(string[] fakeIds)
        {
            Console.WriteLine(string.Join(Environment.NewLine, fakeIds));
        }

        private void CreateIdentifier(string[] tokens)
        {
            IIdentifiable identifiable;
            if (tokens.Length == 3)
            {
                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                string id = tokens[2];
                identifiable = new Citizen(id, name, age);
            }
            else
            {
                string model = tokens[0];
                string id = tokens[1];
                identifiable = new Robot(id, model);
            }

            this.dbBase.Add(identifiable);
        }
    }
}
