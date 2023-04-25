namespace MessageLogger.UnitTests
{
    public class MessageTests
    {
        [Fact]
        public void Check_ContentAndDateTimeAreCreated()
        {
            Message message1 = new Message("test");

            Assert.Equal("test", message1.Content);
            Assert.IsType<DateTime>(message1.CreatedAt);
        }

        
    }
}