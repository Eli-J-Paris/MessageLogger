using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageLogger.UnitTests
{
    public class UserTests
    {

        [Fact]
        public void CheckUserPropertiesAreCreated()
        {
            User user1 =  new User("Eli", "Eli193");

            Assert.Equal("Eli", user1.Name);
            Assert.Equal("Eli193", user1.UserName);
            Assert.Equal(new List<Message>(), user1.UserMessages);
        }

        [Fact]
        public void Check_AddMessageAddsMessage()
        {
            User user1 = new User("Eli", "Eli193");
            Message mes1 = new Message("test");

            user1.addMessage(mes1);

            Assert.Equal(mes1, user1.UserMessages[0]);
        }
    }
}
