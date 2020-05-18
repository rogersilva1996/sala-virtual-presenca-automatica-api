using System.Collections.Generic;

namespace SalaVirtual.Repositories
{
    public interface ISingInClassRepository
    {
        IList<int> ClassExist(string codigoSala);

        void SingIn(string email, string codigoSala, string numeroIdentificacao);
    }
}