using WsBlazor.Data.Services;

namespace WsBlazor.Data.Extentions
{
  public static class ServiceRegistrations
  {
    public static void RegisterAPIs(this IServiceCollection services)
    {
      services.AddSingleton<UserApiService>();
      services.AddSingleton<ChatApiService>();
      services.AddSingleton<ConnectionApiService>();
      services.AddSingleton<MessageApiService>();
    }
  }
}