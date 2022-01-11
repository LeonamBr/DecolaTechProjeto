using System;
using Desafio.Decola.Tech;

namespace DesafioDecola
{
    class projeto
    {
        static RepositorioSeries repositorio = new RepositorioSeries();
        static void Main(string[] args)
        {

            string escolha = Escolha();

            while (escolha != "0")
            {
                
                switch(escolha)
                {
                    case "1":
                        MostrarSeries();
                        break;
                    case "2":
                        InserirSerie();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                escolha = Escolha();
            }

        }

        private static void MostrarSeries()
        {

            System.Console.WriteLine("Series Disponiveis!!");
            System.Console.WriteLine();
            var dicionario = repositorio.Lista();

            if (dicionario.Count == 0)
            {
                System.Console.WriteLine("Não há nenhuma Serie cadastrada.");
                return;
            }

            foreach (var item in dicionario)
            {
                System.Console.WriteLine($"ID {item.Key} - {item.Value}");
            }
        }
        private static void InserirSerie()
        {

            System.Console.WriteLine("Inserir nova série.");
            System.Console.WriteLine();

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                System.Console.WriteLine($"{i} - {Enum.GetName(typeof(Genero), i)}");
            }

        }
        private static string Escolha()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("");
            System.Console.WriteLine("Bem vindo ao Listador de Series do desafio DIO");

            System.Console.WriteLine("Qual opcao deseja acessar?");
            System.Console.WriteLine("1 - Listar Series");
            System.Console.WriteLine("2 - Inserir nova Serie");
            System.Console.WriteLine("3 - Atualizar Serie");
            System.Console.WriteLine("4 - Remover Serie");
            System.Console.WriteLine("0 - Sair");
            System.Console.WriteLine();

            string ? Escolha = Console.ReadLine();
            System.Console.WriteLine();
            
            return Escolha;
        }
    }
}