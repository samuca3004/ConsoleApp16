using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ConsoleApp16
{
    internal class ContaBancaria
    {
        public string Nome { get; set; }
        public int NumeroConta { get; private set; }
        public double Saldo { get; set; }

        public ContaBancaria(string nome, int numeroConta)
        {
            Nome = nome;
            NumeroConta = numeroConta;

        }

        public ContaBancaria(string nome, int numeroConta, double saldo) : this(nome, numeroConta)
        {
            Nome = Nome;
            NumeroConta = numeroConta;
            Saldo = saldo;
            

        }

        public double Depositar(double saldo)
        {
           return Saldo += saldo;
        }

        public double Sacar(double saldo)
        {
           return Saldo -= saldo;
        }

        public override string ToString()
        {
            return "Titular: " + Nome + " Numero da conta: " + NumeroConta + " Seu saldo é de: " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
