using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesUnitario_BLL
{
    public interface IFuncionario
    {
        string Nome { get; set; }
        double Salario { get; set; }
        Cargo Cargo { get; set; }
    }
}
