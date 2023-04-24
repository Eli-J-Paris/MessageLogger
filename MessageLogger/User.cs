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
        }

        public void newMessage(Message message)
        {

        }

    }
}
