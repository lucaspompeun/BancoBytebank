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

            Funcionario carlos = new Funcionario("454.569.895.-85");
            carlos.Nome = "Carlos";
            carlos.Salario = 2000;

            carlos.AumentarSalario();
            Console.WriteLine($"Novo salário do carlos: {carlos.Salario}");

            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            gerenciador.Registrar(carlos);

            Diretor roberta = new Diretor("546.896.452-56");
            roberta.Nome = "Roberta";
            roberta.Salario = 5000;

            roberta.AumentarSalario();
            Console.WriteLine($"Novo salário da roberta {roberta.Salario}");

            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            Funcionario robertaTeste = roberta;
            Console.WriteLine("Bonificação referência diretor: " + roberta.GetBonificacao());
            Console.WriteLine("Bonificação referência funcionário: " + robertaTeste.GetBonificacao());

            gerenciador.Registrar(roberta);

            Console.WriteLine(carlos.GetBonificacao());

            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine("Total bonificações: " + gerenciador.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}
