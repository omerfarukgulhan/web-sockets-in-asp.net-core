namespace WebSockets
{
    public interface IChatClient
    {
        Task ReceiveMessage(string message);
    }
}
