using System;

namespace messages
{
    public class Alert : IMessage
    {
        public Alert()
        {
            Raised = DateTime.Now;
            Data = "Red Alert !";
        }

        public DateTime Raised { get; set; }
        public string Data { get; set; }
    }
}