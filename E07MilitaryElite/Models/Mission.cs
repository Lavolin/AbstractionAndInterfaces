using System;
using System.Collections.Generic;
using System.Text;

namespace E07MilitaryElite
{
    public class Mission : IMission
    {
        public Mission(string codeName, string state)
        {
            CodeName = codeName;
            ParseState(state);
        }

        

        public string CodeName { get; private set; }

        public State State { get; private set; }

        public void CompleteMission()
        {
            if (this.State == State.Finished)
            {
                throw new InvalidOperationException("Mission finished!");
            }

            this.State = State.Finished;
        }

        private void ParseState(string stateString)
        {
            State state;
            bool parsed = Enum.TryParse<State>(stateString, out state);
            if (!parsed)
            {
                throw new ArgumentException("Invalid Mission!");
            }

            this.State = state;
        }

        public override string ToString()
            => $"Code Name: {this.CodeName} State: {this.State.ToString()}";
    }
}
