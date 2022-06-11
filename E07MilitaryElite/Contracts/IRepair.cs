using System;
using System.Collections.Generic;
using System.Text;

namespace E07MilitaryElite
{
    public interface IRepair
    {
        string PartName { get; }
        int HoursWorked { get; }    
    }
}
