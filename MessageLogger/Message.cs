using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace MessageLogger
{
    public class Message
    {
        public string Content;
        public DateTime CreatedAt;
        
        public Message(string content)
        {
            Content = content;
            CreatedAt = DateTime.Now;
        }

    }
}
