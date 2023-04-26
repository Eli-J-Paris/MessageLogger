using MessageLogger;
 List<User> allUsers = new List<User>();
MessageManager messageManager = new MessageManager(allUsers);


Console.WriteLine("---Welcome to Chirp---");
//DRY1
User currentUser = CreateUser(allUsers);
allUsers.Add(currentUser);

Intro();
string login = string.Empty;
string userInput = string.Empty;
while (userInput != "quit")
{
    Console.Write("Add a Message: ");
    userInput = Console.ReadLine();

    if (userInput == "quit")
    {
        break;
    }
    if (userInput == "log out" || userInput == "logout")
    {
        bool needInput = true;
        while (needInput)
        {
            Console.Clear();
            Console.WriteLine("would you like to login into a new or existing account");
            login = Console.ReadLine();
            if (login == "new")
            {
                //DRY1
                currentUser = CreateUser(allUsers);
                allUsers.Add(currentUser);
               

                Intro();
                needInput = false;
            }
            else if (login == "existing")
            {
                currentUser = LogInExisting(allUsers, currentUser);
                WriteAllUserMessages(currentUser);
                needInput = false;

            }
            else if(login == "quit")
            {
                userInput = "quit";
                needInput = false;

            }

        }

    }
    else
    {
        Message newMessage = new Message(userInput);
        currentUser.addMessage(newMessage);
        Console.WriteLine();
        WriteAllUserMessages(currentUser);
    }


     
}
Loading();

//End of Main program

//Start of DataBase

bool backEndExploration = true;
while (backEndExploration)
{
    ListOptions();
    int data = Convert.ToInt32(Console.ReadLine());
    if (data == 1)
    {
        Console.Clear();
        messageManager.AllMessages();
        BackButton();
    }
    else if (data == 2)
    {
        Console.Clear();
        messageManager.totalMessages();
        BackButton();

    }
    else if (data == 3)
    {
        bool exist;
        Console.Clear();
        (exist, currentUser) = ValidateUserExists(allUsers, currentUser);
        if(exist == true)
        {
            //currentUser = LogInExisting(allUsers, currentUser);

            Console.WriteLine("How many messages do you want returned?");
            int num = Convert.ToInt32(Console.ReadLine());

            messageManager.WriteUsersRecentMessages(currentUser, num);
            BackButton();
        }
        else
        {
            Console.WriteLine("USERNAME NOT FOUND");
            BackButton();

        }



    }
    else if (data == 4)
    {
        break;
    }

}








//THIS COULD GO IN THE USER CLASS!!!! ! ! !
static void WriteAllUserMessages(User user)
{
    
    foreach(var message in user.UserMessages)
    {
        Console.WriteLine($"{user.UserName} {message.CreatedAt.ToString("hh:mm tt")} {message.Content}");
    }
}




//create a new user
static User CreateUser(List<User> allUsers)
{
    Console.WriteLine("Lets create a user profile for you.");
    Console.Write("what is your name:");
    string createUser = Console.ReadLine();
    Console.Write("what is your username:");
    string createUserName = Console.ReadLine();
    User newUser = new User(createUser, createUserName);
   // allUsers.Add(newUser);
    return newUser;
}





//log into an exsisting account
static User LogInExisting(List<User> allUsers, User currentUser)
{
    Console.Write("Enter in a Username?");
    string userName = Console.ReadLine();
    foreach (var name in allUsers)
    {
        if (name.UserName.Contains(userName))
        {
            currentUser = name;
            return currentUser;
        }
       
    }
    foreach(var name in allUsers)
    {
        if (!name.UserName.Contains(userName))
        {
            Console.WriteLine("Username Not Found, Lets Create a new user");
            currentUser = CreateUser(allUsers);
            allUsers.Add(currentUser);

            return currentUser;
        }
    }
  
    return currentUser;
}



//intro
static void Intro()
{
    Console.WriteLine("To log out of your user profile, enter 'log out'. TO quit the applcation enter 'quit'.");
}


static void Loading()
{
    for (int i = 0; i < 2; i++)
    {
        Console.Clear();
        Console.WriteLine("Loading Data");
        Thread.Sleep(500);
        Console.Clear();
        Console.WriteLine("Loading Data.");
        Thread.Sleep(500);
        Console.Clear();
        Console.WriteLine("Loading Data. .");
        Thread.Sleep(500);
        Console.Clear();
        Console.WriteLine("Loading Data. . .");
        Thread.Sleep(500);
        Console.Clear();

    }
}


static void ListOptions()
{
    Console.WriteLine("--PROGRAM DATA--\n");
    Console.WriteLine("1: MESSAGE DATA BASE\n \n \n");
    Console.WriteLine("2: TOTAL MESSAGE COUNT\n \n \n");
    Console.WriteLine("3: RETURN A USERS RECENT MESSAGES\n \n \n");
    Console.WriteLine("4: END");    
}

static void BackButton()
{
    Console.Write("\n\n\n\n\n\nPRESS ANY KEY TO GO BACK");
    Console.ReadLine();
    Console.Clear();
}

static (bool, User) ValidateUserExists(List<User> allUsers, User currentUser)
{
    
    Console.Write("Enter in a Username?");
    string userName = Console.ReadLine();
    foreach (var name in allUsers)
    {
        if (name.UserName.Contains(userName))
        {
            currentUser = name;
            return (true,currentUser); 
        }

    }
    foreach (var name in allUsers)
    {
        if (!name.UserName.Contains(userName))
        {
            return (false, currentUser);
        }
    }

    return (true, currentUser);

}