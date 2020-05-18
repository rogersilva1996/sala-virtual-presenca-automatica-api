using SalaVirtual.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalaVItual.Services.Services
{
    public class PresencaService : IPresencaService
    {
        private readonly IPresencaRepository _presencaRepository;

        public PresencaService(IPresencaRepository presencaRepository)
        {
            _presencaRepository = presencaRepository;
        }

        public void AdicionarPresenca(string codigosala)
        {
            try
            {
                _presencaRepository.Presenca(codigosala);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
