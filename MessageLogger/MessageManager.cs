using MessageLogger;
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


        public void AllMessages()
        {
            List<string> allUserMessages = new List<string>();
            foreach(var user in Users)
            {
                foreach(var message in user.UserMessages)
                {
                    Console.WriteLine($"{user.UserName} {message.CreatedAt.ToString("hh:mm tt")} wrote: {message.Content}");
                }
            }
        }

       public void WriteAllMessagesForAUser(User user)
        {
            foreach (var message in user.UserMessages)
            {
                Console.WriteLine($"{user.UserName} {message.CreatedAt.ToString("hh:mm tt")} {message.Content}");
            }
        }


        public void totalMessages()
        {
            foreach (var user in Users)
            {
                Console.WriteLine($"{user.Name} wrote {user.UserMessages.Count} messages");
            }
        }

        public void returnUsersRecentMessages(User user, int num)
        {
            user.UserMessages.Reverse();

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"{user.UserMessages[i].CreatedAt} {user.UserMessages[i].Content}");
            }
 
        }
    }

}
