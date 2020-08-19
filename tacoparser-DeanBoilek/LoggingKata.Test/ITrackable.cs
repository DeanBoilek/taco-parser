using System.Collections.Generic;

namespace LoggingKata.Test
{
    internal interface ITrackable
    {
        IEnumerable<char> Name { get; }
    }
}