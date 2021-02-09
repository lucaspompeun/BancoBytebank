using BancoBytebank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBytebank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario();

            carlos.Nome = "Carlos";
            carlos.CPF = "454.569.895.-85";
            carlos.Salario = 2000;

            gerenciador.Registrar(carlos);

            Diretor roberta = new Diretor();
            roberta.Nome = "Roberta";
            roberta.CPF = "546.896.452-56";
            roberta.Salario = 5000;

            gerenciador.Registrar(roberta);

            Console.WriteLine(carlos.GetBonificacao());

            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine("Total bonificações: " + gerenciador.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}
