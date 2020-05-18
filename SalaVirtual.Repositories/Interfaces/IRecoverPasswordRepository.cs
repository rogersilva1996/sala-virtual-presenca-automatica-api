using System.Collections.Generic;

namespace SalaVirtual.Repositories
{
    public interface IRecoverPasswordRepository
    {
        IList<int> EmailExist(string email);

        string RecoverPassword(string email);
    }
}