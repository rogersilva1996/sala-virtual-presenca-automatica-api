using System.Collections.Generic;

namespace SalaVirtual.Repositories
{
    public interface ICreateClassRepository
    {
        IList<int> ClassExist(string codigoSala);

        void CreateClass(string codigoSala, string nomeSala, string email, string nomeInstituicao, string numeroIdentificacao, string obseracao, int periodoValidade);
    }
}