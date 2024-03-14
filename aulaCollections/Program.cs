using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aulaCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaDeCarros listaDeCarros = new ListaDeCarros();
            while (true)
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1. Visualizar carros cadastrados");
                Console.WriteLine("2. Adicionar novo carro");
                Console.WriteLine("3. Excluir carro");
                Console.WriteLine("4. Alterar carro");
                Console.WriteLine("5. Sair");
                int opcao;
                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                    continue;
                }
                switch (opcao)
                {
                    case 1:
                        listaDeCarros.VisualizarCarros();
                        break;
                    case 2:
                        listaDeCarros.AdicionarCarro();
                        break;
                    case 3:
                        listaDeCarros.ExcluirCarro();
                        break;
                    case 4:
                        listaDeCarros.AlterarCarro();
                        break;
                    case 5:
                        Console.WriteLine("Saindo do programa.");
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                        break;
                }
                Console.WriteLine("Digite qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}

