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

        //Will want to make all of these messages a return type in the future incase the project "grows" and you need to access specfic bits of data
        //Cant really test a void method with a console.WriteLine is another reason to refactor.
        public void AllMessages()
        {
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
                Console.WriteLine($"{user.UserName} wrote {user.UserMessages.Count} message(s)");
            }
        }

        public void WriteUsersRecentMessages(User user, int num)
        {
            user.UserMessages.Reverse();

            for (int i = 0; i < num; i++)
            {
                if (i >= user.UserMessages.Count)
                {Console.WriteLine($"{user.UserName} only has {user.UserMessages.Count} message(s) stored\n");  break; }

                Console.WriteLine($"{user.UserMessages[i].CreatedAt.ToString("hh:mm tt")} {user.UserMessages[i].Content}");
                
            }
 
        }
    }

}
