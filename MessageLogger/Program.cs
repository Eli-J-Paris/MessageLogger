using MessageLogger;

List<User> allUsers = new List<User>();
List<Message> allMessages = new List<Message>();


Console.WriteLine("---Welcome to Chirp---");
User currentUser = CreateUser();
allUsers.Add(currentUser);

Intro();

string userInput = string.Empty;
while (userInput != "quit")
{
    Console.Write("Add a Message: ");
    userInput = Console.ReadLine();


    if (userInput == "log out" || userInput == "logout")
    {
        bool needInput = true;
        while (needInput)
        {
            Console.Clear();
            Console.WriteLine("would you like to login to a new or exsisting account");
            string login = Console.ReadLine();
            if (login == "new")
            {
                currentUser = CreateUser();
                allUsers.Add(currentUser);
                Intro();
                needInput = false;
            }
            else if (login == "exsisting")
            {
                currentUser = LogInExsisting(allUsers, currentUser);
                WriteAllUserMessages(currentUser);
                needInput = false;

            }

        }

    }
    else if(userInput == "quit")
    {
        break;
    }
    else
    {
        Message newMessage = new Message(userInput);
        allMessages.Add(newMessage);
        currentUser.addMessage(newMessage);
        //WriteMessageToConsole(allMessages);
        Console.WriteLine();
        WriteAllUserMessages(currentUser);
    }
     
}
totalMessages(allUsers);


//End of program

//display all of the users messages
static void WriteAllUserMessages(User user)
{
    foreach(var message in user.UserMessages)
    {
        Console.WriteLine($"{user.UserName} {message.CreatedAt.ToString("hh:mm tt")} {message.Content}");
    }
}




//create a new user
static User CreateUser()
{
    Console.WriteLine("Lets create a user profile for you.");
    Console.Write("what is your name:");
    string createUser = Console.ReadLine();
    Console.Write("what is your username:");
    string createUserName = Console.ReadLine();
    User newUser = new User(createUser, createUserName);
    return newUser;
}


//Display total message count for each user
static void totalMessages(List<User> allUsers)
{
    foreach(var user in allUsers)
    {
        Console.WriteLine($"{user.Name} wrote {user.UserMessages.Count} messages");
    }
}



//log into an exsisting account
static User LogInExsisting(List<User> allUsers, User currentUser)
{
    Console.Write("what is your Username?");
    string userName = Console.ReadLine();
    foreach (var name in allUsers)
    {
        if (name.UserName.Contains(userName))
        {
            currentUser = name;
            break;
        }
    }
    return currentUser;
}



//intro
static void Intro()
{
    Console.WriteLine("To log out of your user profile, enter 'log out'. TO quit the applcation enter 'quit'.");
}

//Might need later???
static void WriteMessageToConsole(List<Message> messages)
{
    foreach (var message in messages)
    {
        Console.WriteLine($"{message.CreatedAt.ToString("hh:mm tt")} {message.Content}");
    }
}



//Console.Write("what is your Username?");
//string userName = Console.ReadLine();
//foreach (var name in allUsers)
//{
//    if (name.UserName.Contains(userName))
//    {
//        currentUser = name;
//    }

//}