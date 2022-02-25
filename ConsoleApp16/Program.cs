using System;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria NovaConta;
            Console.Write("Entre com nome: ");
            string nome = Console.ReadLine();
            Console.Write("Entre numero da conta: ");
            int nConta = int.Parse(Console.ReadLine());
            Console.Write("Deseja fazer um deposito inicial: S/N ");
            char resp = char.Parse(Console.ReadLine());

            if(resp == 's' || resp == 'S')
            {
                Console.Write("Entre com valor para deposito: ");
                double dep = double.Parse(Console.ReadLine());
                
                NovaConta = new ContaBancaria(nome, nConta);
                double sal = NovaConta.Depositar(dep);
                Console.WriteLine();
                Console.WriteLine(NovaConta);
                Console.WriteLine();
            }
            else
            {
                NovaConta = new ContaBancaria(nome, nConta);
                Console.WriteLine(NovaConta);
            }


            char d = default;
            do
            {
                
                Console.Write("Deseja fazer um novo deposito: S/N ");
                d = char.Parse(Console.ReadLine());
                if (d == 's' || d == 'S')
                {
                    Console.Write("Qual Valor para deposito: ");
                    double dep = double.Parse(Console.ReadLine());
                    NovaConta.Depositar(dep);
                    Console.WriteLine();
                    Console.WriteLine(NovaConta);
                    Console.WriteLine();
                }
                

            } while(d == 'S' || d == 's');

            do
            {
                Console.WriteLine();
                Console.Write("Deseja fazer um saque: S/N ");
                d = char.Parse(Console.ReadLine());
                if (d == 's' || d == 'S')
                {
                    
                    Console.Write("Digite o valor do saque: ");
                    double dep = double.Parse(Console.ReadLine());
                    NovaConta.Sacar(dep);
                    Console.WriteLine();
                    Console.WriteLine(NovaConta);
                    Console.WriteLine();
                }


            } while (d == 'S' || d == 's');

            Console.WriteLine();
            Console.WriteLine(NovaConta);
            Console.WriteLine();

            Console.WriteLine("Obrigado por Utilizar Samuel Banks");


        }
    }
}
