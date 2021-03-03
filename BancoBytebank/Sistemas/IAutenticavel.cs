using BancoBytebank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBytebank.Sistemas
{
    public interface IAutenticavel
    {
        bool Autenticar(string senha);
    }
}
