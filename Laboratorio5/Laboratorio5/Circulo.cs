using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio5
{
    class Circulo
    {
        #region "Memoria Privada"
        private double coordX;
        private double coordY;
        private double raio;
        #endregion

        #region "Construtores"
        public Circulo() : this(0, 0, 1) { }
        public Circulo(double x, double y, double r)
        {
            coordX = x;
            coordY = y;
            raio = Math.Abs(r);
        }
        #endregion

        #region "Propriedades Privada"
        public double CentroX
        {
            get { return coordX; }
            set { coordX = value; }
        }
        public double CentroY
        {
            get { return coordY; }
            set { coordY = value; }
        }
        public double Raio
        {
            get { return raio; }
            set { raio = value; }
        }
        #endregion

        #region "Metodos Publicos"
        public override string ToString()
        {
            return "(" + string.Format("{0:F2}", CentroX + ";" + string.Format("{0:F2}", CentroY) + ") raio=" + string.Format("{0:F2}", Raio));
        }
        #endregion
    }
}
