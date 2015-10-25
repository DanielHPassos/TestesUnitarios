using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesUnitario_BLL
{
    public class Calculo
    {
        public double CalcularAumento(IFuncionario funcionario)
        {
            double temp = 0;
            switch (funcionario.Cargo)
            {
                case Cargo.DesenvolvedorFrontEnd:
                   temp = funcionario.Salario * 1.05;
                    break;
                case Cargo.DesenvolvedorBackEnd:
                    temp = funcionario.Salario *= 1.10;
                    break;
                case Cargo.DBA:
                    temp = funcionario.Salario *= 1.15;
                    break;
            }
            return temp;
        }
    }
}
