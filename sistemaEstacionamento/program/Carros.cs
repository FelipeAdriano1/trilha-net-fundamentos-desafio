using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    public class Carros
    {
        private string nome = "Desconhecido";
        private string placa = "xxx-1234";

        public Carros(string nome, string placa)
        {
            this.nome = nome;
            this.placa = placa;
        }

        public string getPlaca() 
        {
            return placa;
        }

        public string getNome() 
        {
            return nome;
        }
    }
}
