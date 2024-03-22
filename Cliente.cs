using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GereClientes
{
    internal class Cliente
    {
        public string Nome { get; set; }
        public string NIF { get; set; }
        public double Total { get; set; }
        public List<Compra> ListaCompras { get; set; }

        public Cliente(string nome, string nif)
        {
            Nome = nome;
            NIF = nif;
            ListaCompras = new List<Compra>();
            Total = 0;
        }

        public void AdicionarCompra(Compra compra)
        {
            ListaCompras.Add(compra);
            Total += compra.Total;
        }

        public void RemoverCompra(int index)
        {
            Total -= ListaCompras[index].Total;
            ListaCompras.RemoveAt(index);
        }

        public override string ToString()
        {
            return $"{Nome} ({NIF})";
        }
    }
}
