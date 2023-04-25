using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageLogger
{
    public class User
    {
        public string Name;
        public string UserName;
        public List<Message> UserMessages;

        public User(string name, string userName)
        {
            Name = name;
            UserName = userName;
            UserMessages = new List<Message>();
        }

        public void addMessage(Message message)
        {
            UserMessages.Add(message);
        }

    }
}
