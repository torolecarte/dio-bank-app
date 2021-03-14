using Dio.Bank.Classes;
using System;
using System.Collections.Generic;

namespace Dio.Bank
{
    class Program
    {

        static void Main(string[] args)
        {
            //var conta = new Conta(Enum.TipoConta.PessoaFisica, 0, 0, "Heitor");
            Operacoes.CriarContasIniciais();

            var optUsuario = Operacoes.ObterOpcaoUsuario();

            while (optUsuario != "X")
            {
                switch (optUsuario)
                {
                    case "1":
                        Operacoes.ListarContas();
                        break;
                    case "2":
                        Operacoes.InserirConta();
                        break;
                    case "3":
                        Operacoes.Transferir();
                        break;
                    case "4":
                        Operacoes.Sacar();
                        break;
                    case "5":
                        Operacoes.Depositar();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        break;
                }

                optUsuario = Operacoes.ObterOpcaoUsuario();
            }

            Console.WriteLine("Obrigado por utilizar nossos serviços!");
            Console.ReadLine();
        }
    }
}
