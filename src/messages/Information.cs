using System;

namespace messages
{
    public class Information: IMessage
    {
        public Information()
        {
            Data = "";
        }

        public Information(string data)
        {
            Raised = DateTime.Now;
            Data = data;
        }

        public DateTime Raised { get; set; }
        public string Data { get; set; }
    }
}
