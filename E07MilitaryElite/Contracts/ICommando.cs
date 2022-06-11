using System;
using System.Collections.Generic;
using System.Text;

namespace E07MilitaryElite
{
    public interface ICommando : ISpecialisedSoldier
    {
        IReadOnlyCollection<IMission> Missions { get; }
    }
}
