using SalaVItual.Services.ViewModels;

namespace SalaVItual.Services.Services
{
    public interface ICreateClassService
    {
        bool Create(CreateClassViewModel vm);
    }
}