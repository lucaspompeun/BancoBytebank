using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBytebank.Funcionarios
{
    public class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; set; }

        public Funcionario(string cpf)
        {
            Console.WriteLine("Criando funcionário");

            this.CPF = cpf;

            TotalDeFuncionarios++;
        }

        public virtual void AumentarSalario()
        {
            Salario = Salario * 1.1;
        }

        public virtual double GetBonificacao()
        {
            return this.Salario * 0.10;
        }
    }
}
