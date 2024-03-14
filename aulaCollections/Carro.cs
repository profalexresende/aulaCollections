using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aulaCollections
{
    class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Cor { get; set; }

        public Carro(string marca, string modelo, int ano, string cor)
        {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            Cor = cor;
        }
    }
}

