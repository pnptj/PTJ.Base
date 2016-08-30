using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTJ.Base.MessageChannel
{
    public class Message
    {
        public enum MessageType
        {
            Nothing = 0,
            Information = 1,
            Validation = 10,
            Security = 20,
            Warning = 50,
            Abbend = 100,
        }

        public int Ordinal;
        public MessageType msgType;
        public DateTime EventTime;
        public string ExceptionMessage;

        public int ordinal{ get { return this.Ordinal; } set { this.Ordinal = value; } }
        public MessageType MsgType { get { return this.msgType; } set { this.msgType = value; } }
        public DateTime eventTime { get { return this.EventTime; } set { this.EventTime = value; } }
        public string exceptionMessage { get { return this.ExceptionMessage; } set { this.ExceptionMessage = value; } }
    }
}
