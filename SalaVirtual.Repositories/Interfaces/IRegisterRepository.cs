using System.Collections.Generic;

namespace SalaVirtual.Repositories
{
    public interface IRegisterRepository
    {
        IList<int> ValidateCreateAcout(string email);

        void CreateAcout(string nome, string email, string senha);
    }
}