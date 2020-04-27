using SalaVItual.Services.ViewModels;

namespace SalaVItual.Services.Services
{
    public interface IRegisterService
    {
        bool Register(UserViewModel user);
    }
}