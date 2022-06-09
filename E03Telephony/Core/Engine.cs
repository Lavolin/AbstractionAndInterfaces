using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace E03Telephony
{
    public class Engine
    {
        private Smartphone smartphone;
        private IList<string> phoneNumbers;
        private IList<string> urls;

        public Engine()
        {
            this.smartphone = new Smartphone();
            this.phoneNumbers = new List<string>();
            this.urls = new List<string>();
        }

        public void Run()
        {
            this.phoneNumbers = Console.ReadLine().Split().ToList();
            this.urls = Console.ReadLine().Split().ToList();

            CallPhoneNumbers();
            BrowseUrls();
        }

        
        private void CallPhoneNumbers()
        {
            foreach (var number in this.phoneNumbers)
            {
                try
                {
                    Console.WriteLine(this.smartphone.Call(number));
                }
                catch (ArgumentException ae)
                {

                    Console.WriteLine(ae.Message);
                }
            }
        }

        private void BrowseUrls()
        {
            foreach (var url in this.urls)
            {
                try
                {
                    Console.WriteLine(this.smartphone.Browse(url));
                }
                catch (ArgumentException ae)
                {

                    Console.WriteLine(ae.Message);
                }
            }
        }
    }
}
