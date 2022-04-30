using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Funcionario : Pessoa
    {
        public DateTime DataAdmissao { get; set; }
        public string Registro { get; set; }
    }

    public class Processo
    {
        public void Execucao()
        {
            var funcionario = new Funcionario()
            {
                Nome = "Lorram N de Oliveira",
                DataNascimento = Convert.ToDateTime("1990/20/12"),
                DataAdmissao = DateTime.Now,
                Registro = "0121245"
            };

            funcionario.CalcularIdade();
        }
    }
}

