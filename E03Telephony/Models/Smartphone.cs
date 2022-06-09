using System;
using System.Linq;

namespace E03Telephony
{
    public class Smartphone : ICallable, IBrowsable
    {

        public string Call(string number)
        {
            if (!number.All(x => char.IsDigit(x)))
            {
                throw new ArgumentException(ExceptionMessages.invalidCallingMessage);
            }

            return number.Length > 7 ? $"Calling... {number}" : $"Dialing... {number}";
        }

        public string Browse(string url)
        {
            if (url.Any(x => char.IsDigit(x)))
            {
                throw new ArgumentException(ExceptionMessages.invalidBrowsingMessage);
            }

            return $"Browsing: {url}!";
        }
    }
}
