using System;
using System.Collections.Generic;
using System.Text;

namespace E03Telephony
{
    public interface ICallable
    {
        string Call(string number);
    }
}
