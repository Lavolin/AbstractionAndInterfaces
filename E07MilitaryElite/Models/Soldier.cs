using System;
using System.Collections.Generic;
using System.Text;

namespace E07MilitaryElite
{
    public abstract class Soldier : ISoldier
    {
        protected Soldier(string id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public string Id { get; }

        public string FirstName { get; }

        public string LastName { get; }

        public override string ToString()
            => $"Name: {this.FirstName} {this.LastName} Id: {this.Id}";
    }
}
