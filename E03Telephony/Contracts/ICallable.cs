using System;
using System.Collections.Generic;
using System.Text;

namespace E03Telephony.Contracts
{
    public interface ICallable
    {
        string Call(string number);
    }
}
