using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesUnitario_BLL
{
    public class Funcionario : IFuncionario
    {
        public string Nome { get; set; }
        public double Salario { get; set; }
        public Cargo Cargo { get; set; }

        public Funcionario(string nome, double salario, Cargo cargo)
        {
            Nome = nome;
            Salario = salario;
            Cargo = cargo;
        }
    }
    public enum Cargo
    {
        DesenvolvedorFrontEnd = 1,
        DesenvolvedorBackEnd = 2,
        DBA = 3,

    }
}

