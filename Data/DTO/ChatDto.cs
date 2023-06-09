namespace WsBlazor.Data.DTO
{
  public class Chat
  {
    public Guid Id { get; set; }
    public List<User> Users { get; set; } = new List<User>();
    public List<Message> Messages { get; set; } = new List<Message>();
  }
}