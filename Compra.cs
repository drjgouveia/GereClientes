using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GereClientes
{
    internal class Compra
    {
        public DateTime DataHora { get; set; }
        public List<LinhaCompra> LinhasCompra { get; set; }
        public double Total { get; set; }

        public Compra()
        {
            DataHora = DateTime.Now;
            LinhasCompra = new List<LinhaCompra>();
            Total = 0;
        }

        public void AdicionarLinhaCompra(LinhaCompra linhaCompra)
        {
            LinhasCompra.Add(linhaCompra);
            Total += linhaCompra.Preco;
        }

        public void RemoverLinhaCompra(int indice)
        {
            Total -= LinhasCompra[indice].Preco;
            LinhasCompra.RemoveAt(indice);
        }

        public override string ToString()
        {
            return $"{DataHora} | {Total}€";
        }
    }
}
