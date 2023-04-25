using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageLogger
{
    public class MessageManager
    {
        public List<User> Users;

        public MessageManager( List<User> user)
        {
            Users = user;
        }


        public List<string> AllMessages()
        {
            List<string> allUserMessages = new List<string>();
            foreach(var user in Users)
            {
                foreach(var message in user.UserMessages)
                {
                    allUserMessages.Add(message.Content);
                }
            }

            return allUserMessages;
        }
    }

}
