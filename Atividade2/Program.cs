using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            Console.WriteLine("Informe seu Primeiro Nome");
            nome = Console.ReadLine();
            Console.WriteLine("Informe sua Idade");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe seu Telefone");
            int telefone = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o salário");
            float salario = float.Parse(Console.ReadLine());
            Console.WriteLine("Nome Informado foi: " + nome);
            Console.WriteLine("Idade Informada foi: " + idade);
            Console.WriteLine("Telefone Informado foi: " + telefone);
            Console.WriteLine("O salário informado foi: " + salario);
            Console.Read();
        }
    }
}
