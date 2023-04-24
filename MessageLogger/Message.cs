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
        public Dictionary<string,string> AllMessages;
        public Message()
        {
            Content = string.Empty;
            AllMessages = new Dictionary<string, string>();

        }

        public void StoreMessage(string content)
        {
            Content = content;
            CreatedAt = DateTime.Now;
            
            AllMessages.Add(CreatedAt.ToLongTimeString(),content);
        }

        public void PrintMessages()
        {
            foreach(var message in AllMessages)
            {
                Console.WriteLine($"{message.Key} {message.Value}");
            }
        }
    }
}
