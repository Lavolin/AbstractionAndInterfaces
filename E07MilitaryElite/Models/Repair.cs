using System;
using System.Collections.Generic;
using System.Text;

namespace E07MilitaryElite
{
    public class Repair : IRepair
    {
        public Repair(string partName, int hoursWorked)
        {
            PartName = partName;
            HoursWorked = hoursWorked;
        }

        public string PartName { get; }

        public int HoursWorked { get; }

        public override string ToString()
            => $"Part Name: {this.PartName} Hours Worked: {this.HoursWorked}";
    }
}
