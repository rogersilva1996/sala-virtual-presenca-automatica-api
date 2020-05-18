using System;
using System.Collections.Generic;
using System.Text;

namespace SalaVItual.Services.ViewModels
{
    public class CreateClassViewModel
    {
        public string nomeSala { get; set; }

        public string email { get; set; }

        public string numeroIdentificacao { get; set; }

        public string nomeInstituicao { get; set; }

        public string observacao { get; set; }

        public int periodoValidade { get; set; }
    }
}
