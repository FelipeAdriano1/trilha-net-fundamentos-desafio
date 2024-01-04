using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    public class Estacionamento
    {
        private decimal precoFixo;
        private decimal precoHora;
        private decimal faturamento = 0M;
        private List<Carros> cadastroCarros = new List<Carros>();  

        public Estacionamento(decimal precoFixo, decimal precoHora) 
        {
            this.precoFixo = precoFixo;
            this.precoHora = precoHora;
        }

        public void cadastrarCarros()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("DIGITE O NOME DO CARRO: ");
            Console.ForegroundColor = ConsoleColor.White;
            string nome = Console.ReadLine();
            while (string.IsNullOrEmpty(nome))
            {
                Console.WriteLine("POR FAVOR DIGITE O NOME DO CARRO.");
                nome = Console.ReadLine();
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nDIGITE A PLACA DO CARRO: ");
            Console.ForegroundColor = ConsoleColor.White;
            string placa = Console.ReadLine();
            while (string.IsNullOrEmpty(placa))
            {
                Console.WriteLine("POR FAVOR DIGITE A PLACA DO CARRO.");
                placa = Console.ReadLine();
            }

            Carros carro = new Carros(nome, placa);
            cadastroCarros.Add(carro);
        }


        public string pesquisarCarros(string placa)
        {
            if (!string.IsNullOrEmpty(placa))
            {
                foreach (Carros carro in cadastroCarros)
                {
                    if (String.Compare(placa, carro.getPlaca(), true) == 0)
                    {
                        Console.Clear();
                        string retorno = $"\tDADOS DO VEÍCULO\n\nNOME DO VEÍCULO: {carro.getNome()}\nPLACA: {carro.getPlaca()}\n";
                        return retorno;
                    }
                }
                Console.Clear();
                string retornoNulo = $"\nNÃO FOI POSSÍVEL ENCONTRAR O CADASTRO\n";
                Console.Clear();
                return retornoNulo;

            }
           return null;
        }


        public string listarTodosVeiculos() 
        {
            int cont = 0;
            string retorno = string.Empty;
            foreach (Carros carro in cadastroCarros)
            {
                cont++;
                retorno += $"VEÍCULO {cont}\n\nNOME DO VEÍCULO : {carro.getNome()}\nPLACA DO VEÍCULO : {carro.getPlaca()}\n\n";
            }
            return retorno;
        }


        public string RemoverCadastro(string placa, decimal quantHoras) 
        {
            if (!string.IsNullOrEmpty(placa))
            {
                foreach (Carros carro in cadastroCarros)
                {
                    if (String.Compare(placa, carro.getPlaca(), true) == 0)
                    {
                        decimal subtotal = quantHoras * precoHora + precoFixo;
                        faturamento += subtotal;

                        cadastroCarros.Remove(carro);

                        string retornoTrue = $"CADASTRO REMOVIDO COM SUCESSO !\nSUBTOTAL: {subtotal:C}";
                        return retornoTrue;
                    }
                }
            }
            string retornoNulo = $"NÃO FOI POSSÍVEL REMOVER O CADASTRO";
            return retornoNulo;
        }


        public decimal getFaturamento() 
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            return faturamento;
        }

        public decimal getPrecoFixo() 
        {
            return precoFixo;
        }

        public decimal getPrecoHora()
        {
            return precoHora;
        }
    }
}
