namespace SalaVirtual.Repositories
{
    public interface IRecoverPasswordRepository
    {
        string RecoverPassword(string email);
    }
}