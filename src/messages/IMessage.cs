using System;

namespace messages
{
    public interface IMessage
    {
        DateTime Raised { get; set; }
        string Data { get; set; }
    }
}