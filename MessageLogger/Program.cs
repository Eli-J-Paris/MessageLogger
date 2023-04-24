using MessageLogger;

Console.WriteLine("Welcome to Chirp");
string userMessage = string.Empty;
Message messageHandeler = new Message();

while (userMessage != "quit")
{
    Console.WriteLine("Add a Message or type 'quit' to exit");
    userMessage = Console.ReadLine();
    if(userMessage == "quit")
    {
        break;
    }

    messageHandeler.StoreMessage(userMessage);
    messageHandeler.PrintMessages();
}

Console.WriteLine($"Thank you for using Chirp you logged {messageHandeler.AllMessages.Count} messages");












