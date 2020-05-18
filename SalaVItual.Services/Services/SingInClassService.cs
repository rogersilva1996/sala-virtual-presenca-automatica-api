using SalaVirtual.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalaVItual.Services.Services
{
    public class SingInClassService : ISingInClassService
    {
        private readonly ISingInClassRepository _singInClassRepository;

        public SingInClassService(ISingInClassRepository singInClassRepository)
        {
            _singInClassRepository = singInClassRepository;
        }

        public bool Connect(string email, string codigoSala, string numeroIdentificacao)
        {
            try
            {
                IList<int> result = _singInClassRepository.ClassExist(codigoSala);

                if(result.Count > 0)
                {
                    _singInClassRepository.SingIn(email, codigoSala, numeroIdentificacao);

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
