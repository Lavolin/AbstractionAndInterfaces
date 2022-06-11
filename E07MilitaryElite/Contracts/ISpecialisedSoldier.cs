using System;
using System.Collections.Generic;
using System.Text;

namespace E07MilitaryElite
{ 
    public interface ISpecialisedSoldier : ISoldier
    {
        Corps Corps { get; }
    }
}
