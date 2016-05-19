using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppTeste1
{
    [Flags]
    public enum enmTitulacao
    {
        Basico         = 0,
        Medio          = 1,
        Tecnico        = 2,
        Graduacao      = 4,
        Especializacao = 8,
        Mestrado       = 16,
        Doutor         = 32
    }

    class clProfessor : clPessoa
    {

        #region "Memória privada"

            private string       strLCodigoFuncional;
            private enmTitulacao enmLTitulacao;
            private DateTime     datLDT_Admissao;

        #endregion

        #region "Propriedades Públicas"

            public string CodigoFuncional
            {
                set { strLCodigoFuncional = value; }
                get { return strLCodigoFuncional;  }
            }

            public enmTitulacao Titulacao
            {
                set { enmLTitulacao = value; }
                get { return enmLTitulacao;  }
            }

            public DateTime DT_Admissao
            {
                set { datLDT_Admissao = value; }
                get { return datLDT_Admissao;  }
            }

        #endregion
    }
}
