using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GereClientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void replaceItemsInListBox<T>(ListBox listBox, List<T> items)
        {
            listBox.Items.Clear();
            foreach (object item in items)
            {
                listBox.Items.Add(item);
            }
        }

        private void btnAdicionarNovoCliente_Click(object sender, EventArgs e)
        {
            bool isNifValid = int.TryParse(txtBoxNIF.Text, out int n) && txtBoxNIF.Text.Length == 9;
            bool isNomeValid = txtBoxNome.Text.Length > 0;
            if (!isNifValid)
            {
                MessageBox.Show("NIF inválido");
                return;
            }
            if (!isNomeValid)
            {
                MessageBox.Show("Nome inválido");
                return;
            }
            Cliente cliente = new Cliente(txtBoxNome.Text, txtBoxNIF.Text);
            listBoxClientes.Items.Add(cliente);
        }

        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente cliente = listBoxClientes.SelectedItem as Cliente;
            lblNomeCliente.Text = cliente.Nome;
            lblNIFCliente.Text = cliente.NIF;
            lblTotalValor.Text = $"{cliente.Total.ToString("0.##")} €";
            replaceItemsInListBox(listBoxCompras, cliente.ListaCompras);
            replaceItemsInListBox(listBoxLinhasCompras, new List<object>());
        }

        private void btnApagarLinha_Click(object sender, EventArgs e)
        {
            if (listBoxLinhasCompras.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma linha");
                return;
            }
            if (listBoxLinhasCompras.Items.Count == 0)
            {
                MessageBox.Show("Não há linhas para apagar");
                return;
            }
            if (listBoxCompras.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma compra");
                return;
            }
            Cliente cliente = (listBoxClientes.SelectedItem as Cliente);
            cliente.RemoverCompra(listBoxCompras.SelectedIndex);
            (listBoxCompras.SelectedItem as Compra).RemoverLinhaCompra(listBoxLinhasCompras.SelectedIndex);
            listBoxLinhasCompras.Items.RemoveAt(listBoxLinhasCompras.SelectedIndex);
            cliente.AdicionarCompra(listBoxCompras.SelectedItem as Compra);
            lblTotalValor.Text = $"{(listBoxClientes.SelectedItem as Cliente).Total.ToString("0.##")} €";
            replaceItemsInListBox(listBoxCompras, cliente.ListaCompras);
            replaceItemsInListBox(listBoxLinhasCompras, new List<object>());
        }

        private void btnAdicionarLinhaCompras_Click(object sender, EventArgs e)
        {
            if (listBoxClientes.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um cliente");
                return;
            }
            bool isValidValor = double.TryParse(txtBoxValor.Text, out double valor) && valor > 0;
            bool isValidDescricao = txtBoxDescricao.Text.Length > 0;
            if (!isValidValor)
            {
                MessageBox.Show("O valor de linha de compra é inválido!");
                return;
            }
            if (!isValidDescricao)
            {
                MessageBox.Show("A descrição de linha de compra é inválida!");
                return;
            }
            LinhaCompra linhaCompra = new LinhaCompra(txtBoxDescricao.Text, valor);
            listBoxLinhasCompras.Items.Add(linhaCompra);
        }

        private void btnCriarCompra_Click(object sender, EventArgs e)
        {
            Cliente cliente = listBoxClientes.SelectedItem as Cliente;
            Compra compra = new Compra();
            if (listBoxLinhasCompras.Items.Count == 0)
            {
                MessageBox.Show("Adicione linhas de compra");
                return;
            }
            foreach (LinhaCompra linhaCompra in listBoxLinhasCompras.Items)
            {
                compra.AdicionarLinhaCompra(linhaCompra);
            }
            cliente.AdicionarCompra(compra);
            listBoxLinhasCompras.Items.Clear();
            lblTotalValor.Text = $"{cliente.Total.ToString("0.##")} €";
            replaceItemsInListBox(listBoxCompras, cliente.ListaCompras);
        }

        private void listBoxCompras_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCompras.SelectedIndex != -1)
                replaceItemsInListBox(listBoxLinhasCompras, (listBoxCompras.SelectedItem as Compra).LinhasCompra);
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (listBoxCompras.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma compra");
                return;
            }
            if (listBoxCompras.Items.Count == 0)
            {
                MessageBox.Show("Não há compras para apagar");
                return;
            }
            if (listBoxClientes.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um cliente");
                return;
            }
            (listBoxClientes.SelectedItem as Cliente).RemoverCompra(listBoxCompras.SelectedIndex);
            listBoxCompras.Items.RemoveAt(listBoxCompras.SelectedIndex);
        }
    }
}
