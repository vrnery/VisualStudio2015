using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplicationTeste1
{
    class clEndereco
    {
        #region "Memória Privada"
        private string strLLogradouro = null;
        private string strLNro = null;
        #endregion

        #region "Propriedades"
        public string Logradouro
        {
            get { return strLLogradouro; }
            set { strLLogradouro = value; }
        }
        public string Nro
        {
            get { return strLNro; }
            set { strLNro = value; }
        }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string CEP { get; set; }
        public string UF { get; set; }
        public string Pais { get; set; }
        #endregion

        #region "Construtores"
        public clEndereco() { }
        public clEndereco(string Logradouro, string Nro)
        {
            // Logradouro e nro são obrigatórios!
            if (Logradouro.Trim().Length == 0) throw new ArgumentNullException("Logradouro");
            if (Nro.Trim().Length == 0) throw new ArgumentNullException("Numero");
            this.Logradouro = Logradouro;
            this.Nro = Nro;
        }
        #endregion
    }
}
