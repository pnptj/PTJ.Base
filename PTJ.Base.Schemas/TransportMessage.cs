using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTJ.Base.Schemas
{
    public class TransportMessage<T>
    {
        public T Results;
        public List<MessageChannel.Message> lstMessages;
        public T Data
        {
            get { return this.Results; }
            set { this.Results = value; }
        }
        public MessageChannel.Message[] Messages
        {
            get { return this.lstMessages == null ? null : this.lstMessages.ToArray(); }
            set { this.lstMessages = value.ToList(); }
        }
    }
}
