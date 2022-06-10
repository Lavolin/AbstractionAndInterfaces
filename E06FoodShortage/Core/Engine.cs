using System;
using System.Collections.Generic;
using System.Linq;

namespace E06FoodShortage
{
    public class Engine
    {
        private List<IBuyer> dBase;
        private IBuyer currBuyer;
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
                
                FindBuyer(input);
                currBuyer?.BuyFood();

                input = Console.ReadLine();
            }

            PrintTotalFood();
            
        }

        private void FilldBase(int n)
        {
            for (int i = 0; i < n; i++)
            {
                string[] buyersInfo = Console.ReadLine().Split();
                string name = buyersInfo[0];
                int age = int.Parse(buyersInfo[1]);
                IBuyer buyer = null;

                switch (buyersInfo.Length)
                {
                    case 3:
                        {
                            string group = buyersInfo[2];
                            buyer = new Rebel(name, age, group);
                            break;
                        }

                    case 4:
                        {
                            string id = buyersInfo[2];
                            string birthdate = buyersInfo[3];
                            buyer = new Citizen(name, age, id, birthdate);
                            break;
                        }
                }

                if (buyer != null)
                {
                    dBase.Add(buyer);
                }
            }
        }

        private void PrintTotalFood()
        {
            Console.WriteLine(dBase.Sum(x => x.Food));
            //int totalFoodBougth = dBase.Sum(x => x.Food);
            //Console.WriteLine(totalFoodBougth);
        }

        private IBuyer FindBuyer(string buyer)
             => this.currBuyer = dBase.FirstOrDefault(b => b.Name == buyer);
        
    }
}
