using System.Collections.Generic;

namespace SalaVirtual.Repositories
{
    public interface ILoginRepository
    {
        IList<int> Login(string email, string senha);
    }
}