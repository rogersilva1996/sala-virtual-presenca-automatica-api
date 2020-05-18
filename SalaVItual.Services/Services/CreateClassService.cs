using SalaVirtual.Repositories;
using SalaVirtual.Util;
using SalaVItual.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalaVItual.Services.Services
{
    public class CreateClassService : ICreateClassService
    {
        private ICreateClassRepository _createClassRepository;
        private CreateCodeClass createCodeClass;
        private bool result = false;

        public CreateClassService(ICreateClassRepository createClassRepository)
        {
            _createClassRepository = createClassRepository;
            createCodeClass = new CreateCodeClass();
        }

        public bool Create(CreateClassViewModel vm)
        {
            try
            {
                while (result == false)
                {
                    string codeClass = createCodeClass.CodeClass();

                    IList<int> consulta = _createClassRepository.ClassExist(codeClass);

                    result = (consulta.Count == 0) ? true : false;

                    if (result)
                    {
                        _createClassRepository.CreateClass(codeClass,
                                                           vm.nomeSala,
                                                           vm.email,
                                                           vm.nomeInstituicao,
                                                           vm.numeroIdentificacao,
                                                           vm.observacao,
                                                           vm.periodoValidade);
                    }
                }

                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }


    }
}
