using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GereClientes
{
    internal class LinhaCompra
    {
        public string Descricao { get; set; }
        public double Preco { get; set; }

        public LinhaCompra(string descricao, double preco)
        {
            Descricao = descricao;
            Preco = preco > 0 ? preco : throw new ArgumentException("Preço não pode ser negativo");
        }

        public override string ToString()
        {
            return $"{Preco}€ {Descricao}";
        }
    }
}
