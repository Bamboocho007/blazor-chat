using myChat.Enums;

namespace WsBlazor.Data.DTO
{
  public class GetMessageQueryDto
  {
    public int Limit { get; set; }
    public MessageDirecton Direction { get; set; } = MessageDirecton.NEXT;
    public DateTime From { get; set; }
  }
}

