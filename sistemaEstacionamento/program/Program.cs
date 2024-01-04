using System;
using System.Globalization;
using System.Numerics;

namespace program
{
    public class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

            int opcaoUusuario = 0;
            bool loop = true;
            decimal precoFixo = 0M;
            decimal precoHora = 0M;

            //PRIMEIRO, COLETAR DO USUÁRIOS OS PREÇOS FIXO E POR HORA DO ESTACIONAMETO

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("||-SEJA BEM-VINDO AO ESTACIONAMENTO !-||\n");
            Console.ForegroundColor = ConsoleColor.White;

            //VERIFICANDO SE VALORES DE PREÇO POR HORA E PREÇO FIXO INSERIDOS SÃO VÁLIDOS
            Console.WriteLine("PRIMEIRO, DIGITE O PREÇO FIXO DO ESTACIONAMENTO: ");
            bool precoFixoBool = decimal.TryParse(Console.ReadLine(), out precoFixo);
            while (!precoFixoBool)
            {
                Console.WriteLine("FORMATO INVÁLIDO, TENTE NOVAMENTE. EX (5,99)");

                precoFixoBool = decimal.TryParse(Console.ReadLine(), out precoFixo);
            }

            Console.WriteLine("DIGITE O PREÇO POR HORA: ");
            bool precoHoraBool = decimal.TryParse(Console.ReadLine(), out precoHora);
            while (!precoHoraBool)
            {
                Console.WriteLine("FORMATO INVÁLIDO, TENTE NOVAMENTE. EX (2,99)");

                precoHoraBool = decimal.TryParse(Console.ReadLine(), out precoHora);
            }

            Estacionamento estacionamento = new Estacionamento(precoFixo, precoHora);
            
            //TÉRMINO DO CADASTRO DE VALORES DO ESTACIONAMENTO
            Console.Clear();

            //MENU DE INTERAÇÃO COM O USUÁRIO
            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\tMENU");
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("\n1 - CADASTRAR VEÍCULO\n2 - LISTAR VEÍCULOS\n3 - LISTAR TODOS OS VEÍCULOS\n4 - REMOVER VEÍCULO\n5 - SAIR\n");
                Console.ForegroundColor = ConsoleColor.Blue;

                Console.WriteLine($"FATURAMENTO : {estacionamento.getFaturamento():C}\n");
                Console.WriteLine($"PREÇO FIXO : {estacionamento.getPrecoFixo():C}\nPREÇO POR HORA : {estacionamento.getPrecoHora():C}");
                Console.ForegroundColor = ConsoleColor.White;

                //VERIFICANDO SE A OPÇÃO QUE O USUÁRIO DIGITOU É VÁLIDA
                bool opcaoBool = int.TryParse(Console.ReadLine(), out opcaoUusuario);
                while (!opcaoBool)
                {
                    Console.WriteLine("OPÇÃO INVÁLIDA, DIGITE NOVAMENTE UMA OPÇÃO DE 1 Á 5.");

                    opcaoBool = int.TryParse(Console.ReadLine(), out opcaoUusuario);
                }
                Console.Clear();

                //SEQUÊNCIA DE OPÇÕES

                switch (opcaoUusuario)
                {
                    //CADASTRANDO VEÍCULOS
                    case 1:
                        estacionamento.cadastrarCarros();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\nCADASTRO EFETUADO COM SUCESSO !\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;

                    //LISTANDO UM VEÍCULO ESPECÍFICO
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("DIGITE A PLACA DO CARRO: ");
                        Console.ForegroundColor = ConsoleColor.White;

                        string placaPesquisa = Console.ReadLine();
                        while (string.IsNullOrEmpty(placaPesquisa))
                        {
                            Console.WriteLine("POR FAVOR DIGITE NOVAMENTE PLACA DO CARRO.");
                            placaPesquisa = Console.ReadLine();
                        }
                        estacionamento.pesquisarCarros(placaPesquisa);

                        string resultadoPesquisa = estacionamento.pesquisarCarros(placaPesquisa);
                        Console.WriteLine(resultadoPesquisa);
                        break;

                    //LISTANDO TODOS OS VEÍCULOS
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("LISTANDO TODOS OS VEÍCULOS CADASTRADOS \n");
                        Console.ForegroundColor = ConsoleColor.White;

                        string resultado = estacionamento.listarTodosVeiculos();

                        Console.WriteLine(resultado);
                        break;

                    //REMOVER VEÍCULO
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("DIGITE A PLACA DO CARRO: ");
                        Console.ForegroundColor = ConsoleColor.White;

                        string placaRemover = Console.ReadLine();
                        while (string.IsNullOrEmpty(placaRemover))
                        {
                            Console.WriteLine("POR FAVOR DIGITE NOVAMENTE PLACA DO CARRO.");
                            placaRemover = Console.ReadLine();
                        }

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("DIGITE A QUANTIDADE DE HORAS QUE O VEÍCULO PERMANECEU NO ESTACIONAMENTO: ");
                        Console.ForegroundColor = ConsoleColor.White;

                        decimal quantHoras = Convert.ToDecimal(Console.ReadLine());
                       
                        string remover = estacionamento.RemoverCadastro(placaRemover, quantHoras);
                        Console.WriteLine(remover); 
                        break;

                    //SAIR DO PROGRAMA
                    case 5:
                        loop = false;
                        break;

                }
            } while (loop == true);
        }
    }
}
