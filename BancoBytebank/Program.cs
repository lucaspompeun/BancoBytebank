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
            CalcularBonificacao();

            Console.ReadLine();
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer pedro = new Designer("454.695.569-56");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("555.555.555-65");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("888.555.555-55");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("558.555.555-55");
            camila.Nome = "Camila";

            Desenvolvedor guilherme = new Desenvolvedor("888.888.888-95");
            guilherme.Nome = "Guilherme";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);
            gerenciadorBonificacao.Registrar(guilherme);

            Console.WriteLine($"Total de bonificações do mês: {gerenciadorBonificacao.GetTotalBonificacao()}");

        }
    }
}
