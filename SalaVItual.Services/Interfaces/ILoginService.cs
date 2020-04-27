using SalaVItual.Services.ViewModels;

namespace SalaVItual.Services.Services
{
    public interface ILoginService
    {
        bool login(UserViewModel user);
    }
}