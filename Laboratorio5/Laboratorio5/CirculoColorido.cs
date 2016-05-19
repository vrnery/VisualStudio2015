using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio5
{
    class CirculoColorido : Circulo
    {
        #region "Memoria Privada"
        private string minhaCor;
        #endregion

        #region "Propriedades Publica"
        public string Cor
        {
            get { return minhaCor; }
            set { minhaCor = value; }
        }
        #endregion

        #region "Construtores"
        public CirculoColorido()
        {
            minhaCor = "preto";
        }
        public CirculoColorido(double x, double y, double r, string c) : base(x, y, r)
        {
            minhaCor = c;
        }
        #endregion

        #region "Metodos Publico"
        public override string ToString()
        {
            return base.ToString() + " cor=" + Cor;
        }
        #endregion
    }
}
