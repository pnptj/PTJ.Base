using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTJ.Base.MessageChannel
{
    public class MessageChannel
    {
        private List<Message> MessageTable = null;

        public MessageChannel()
        {
            MessageTable = new List<Message>();
        }

        public void AddMessage(Message.MessageType type, string message)
        {
            this.MessageTable.Add(new Message(){ EventTime = DateTime.Now, ExceptionMessage = message, msgType = type, Ordinal = this.MessageTable.Count()==0 ? 0 : this.MessageTable.Max(m=> m.Ordinal) + 1});
        }

        public List<Message> Get()
        {
            return this.MessageTable.ToList();
        }

        public List<Message> Get(Message.MessageType type)
        {
            return this.MessageTable.Where(w=> Convert.ToInt32(w.msgType) >= Convert.ToInt32(type)).ToList();
        }

        public Message[] GetClientMessages()
        {
            List<Message> lstClientMessages = new List<Message>();
            if (this.MessageTable.Count() > 0)
            {
                System.IO.StreamWriter wri = new System.IO.StreamWriter(@"C:\Projects\PTJ\PTJ.Base.ServiceLayer\Temp\ApplicationLogg.txt", true);
                this.MessageTable.ToList().ForEach(f => wri.WriteLine(f.EventTime.ToString() + "; " + f.Ordinal.ToString() + "; " + f.MsgType.ToString() + "; " + f.ExceptionMessage.ToString()));
                    wri.Flush(); wri.Close(); wri.Dispose();
            }
            if (this.MessageTable.Where(w => Convert.ToInt32(w.msgType) > Convert.ToInt32(Message.MessageType.Validation)).Count() > 0)
            {
                lstClientMessages.Add(new Message() { Ordinal = 0, msgType = Message.MessageType.Abbend, EventTime = DateTime.Now, ExceptionMessage = "Please Contact the system administrator!!!" });
                lstClientMessages.AddRange(this.MessageTable.Where(w => Convert.ToInt32(w.msgType) <= Convert.ToInt32(Message.MessageType.Validation)).ToList());
            }
            else
            {
                lstClientMessages.AddRange(this.MessageTable); 
            }
            lstClientMessages = lstClientMessages.OrderBy(o => o.EventTime.ToString() + o.Ordinal.ToString()).ToList();
            int ordinal = 0;
            this.MessageTable.ForEach(f => f.Ordinal = ordinal++);

            return lstClientMessages.ToArray();
        }

        public List<Message> GetOfType(Message.MessageType type)
        {
            return this.MessageTable.Where(w => w.msgType == type).OrderBy(o=> o.Ordinal).ToList();
        }

        public void Merge(List<Message> lstMessages)
        {
            this.MessageTable.AddRange(lstMessages);
            this.MessageTable = this.MessageTable.OrderBy(o => o.EventTime.ToString() + o.Ordinal.ToString()).ToList();
            int ordinal = 0;
            this.MessageTable.ForEach(f => f.Ordinal = ordinal++);
        }

        public bool isReadyToCommit()
        {
            return this.MessageTable.Where(w => Convert.ToInt32(w.msgType) > Convert.ToInt32(Message.MessageType.Information)).Count() == 0;
        }
    }
}
