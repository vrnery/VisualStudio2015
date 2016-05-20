using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ServicoWEB1
{
    /// <summary>
    /// Summary description for ServicoPessoa
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicoPessoa : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public double Soma(double v1, double v2)
        {
            return v1 + v2;
        }

        [WebMethod]
        public string Salvar(string cpf, string nome, DateTime dt_nascimento)
        {
            try
            {
                clPessoa p = new clPessoa(cpf, nome, dt_nascimento);
                return "Usuário salvo com sucesso!";
            }
            catch(Exception Erro)
            {
                throw Erro;
            }
        }

        [WebMethod]
        public clPessoa Buscar(string CPF)
        {
            try
            {
                List<clPessoa> lista = new List<clPessoa>();
                lista.Add(new clPessoa("123", "Zezinho", DateTime.Now.AddYears(-12)));
                lista.Add(new clPessoa("456", "Luizinho", DateTime.Now.AddYears(-25)));
                lista.Add(new clPessoa("789", "Uguinho", DateTime.Now.AddYears(-21)));
                lista.Add(new clPessoa("741", "Mariazinha", DateTime.Now.AddYears(-35)));
                lista.Add(new clPessoa("852", "Lilinha", DateTime.Now.AddYears(-11)));

                clPessoa p = null;
                p = lista.Find(x => x.cpf == CPF);
                //p = lista.Where(x => x.cpf == CPF).First();
                //foreach(clPessoa Pe in lista)
                //{
                //    if(Pe.cpf == CPF)
                //    {
                //        p = Pe;
                //        break;
                //    }
                //}
                return p;
            }
            catch(Exception Erro)
            {
                throw Erro;
            }
        }

        [WebMethod]
        public List<clPessoa> BuscarT(int Idade)
        {
            try
            {
                List<clPessoa> lista = new List<clPessoa>();
                lista.Add(new clPessoa("123", "Zezinho", DateTime.Now.AddYears(-12)));
                lista.Add(new clPessoa("456", "Luizinho", DateTime.Now.AddYears(-25)));
                lista.Add(new clPessoa("789", "Uguinho", DateTime.Now.AddYears(-21)));
                lista.Add(new clPessoa("741", "Mariazinha", DateTime.Now.AddYears(-35)));
                lista.Add(new clPessoa("852", "Lilinha", DateTime.Now.AddYears(-11)));

                List<clPessoa> p = null;
                p =  lista.FindAll(x => x.dt_nascimento.Date <= DateTime.Now.AddYears(-Idade));
                //p = lista.Where(x => x.cpf == CPF).First();
                //foreach(clPessoa Pe in lista)
                //{
                //    if(Pe.cpf == CPF)
                //    {
                //        p = Pe;
                //        break;
                //    }
                //}
                return p;
            }
            catch (Exception Erro)
            {
                throw Erro;
            }
        }
    }
}
