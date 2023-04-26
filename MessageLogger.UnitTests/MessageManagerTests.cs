using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageLogger.UnitTests
{
    public class MessageManagerTests
    {
        [Fact]
        public void Check_MessageMangerUserListIsMade()
        {
            User user1 = new User("eli", "eli193");
            List<User> allusers = new List<User> { user1 };

            MessageManager man1 = new MessageManager(allusers);

            Assert.Equal("eli", man1.Users[0].Name);
        }

    



    }
}
