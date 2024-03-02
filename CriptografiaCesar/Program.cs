using System;
using CriptografiaCesar.Entities;

namespace CriptografiaCesar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CifraCesar cifraCesar = new CifraCesar();
            GerarArquivo gerarArquivo = new GerarArquivo();
            string mensagem;

            Console.WriteLine("|---------------------------|");
            Console.WriteLine("| [1] para Criptografar!    |");
            Console.WriteLine("| [2] para Descriptografar! |");
            Console.WriteLine("| [3] para Encerrar!        |");
            Console.WriteLine("|---------------------------|");
                        
            try
            {
                Console.Write("\nInforme a sua escolha: ");
                int opcao = int.Parse(Console.ReadLine());

                if (opcao > 0 && opcao < 4)
                {
                    switch (opcao)
                    {
                        case 1:
                            Console.Write("\nDigite o texto que deseja criptografar: ");
                            mensagem = Console.ReadLine();
                            string mensagemCriptografada = cifraCesar.Criptografar(mensagem);
                            Console.WriteLine(cifraCesar);
                            gerarArquivo.SalvarMensagem(mensagemCriptografada);
                            break;

                        case 2:
                            Console.Write("\nDigite o texto que deseja descriptografar: ");
                            mensagem = Console.ReadLine();
                            string mensagemDescriptografada = cifraCesar.Descriptografar(mensagem);
                            Console.WriteLine(cifraCesar);
                            gerarArquivo.SalvarMensagem(mensagemDescriptografada);
                            break;

                        case 3:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\n[OPÇÃO INVÁLIDA!]");
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("\nUm erro ocorreu: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro inesperado: " + e.Message);
            }
            Console.ReadKey();
        }
    }
}