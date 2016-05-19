using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab01_ApresentacaoMVC.Models
{
    public class Filme
    {
        #region "Memoria Principal"
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public bool Assistido { get; set; }
        #endregion
    }
}