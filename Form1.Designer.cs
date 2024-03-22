namespace GereClientes
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupInserirCliente = new System.Windows.Forms.GroupBox();
            this.btnAdicionarNovoCliente = new System.Windows.Forms.Button();
            this.txtBoxNIF = new System.Windows.Forms.TextBox();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.lblNIFNovoCliente = new System.Windows.Forms.Label();
            this.lblNomeNovoCliente = new System.Windows.Forms.Label();
            this.groupListClientes = new System.Windows.Forms.GroupBox();
            this.listBoxClientes = new System.Windows.Forms.ListBox();
            this.groupDetalhesCliente = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnCriarCompra = new System.Windows.Forms.Button();
            this.listBoxCompras = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnApagarLinha = new System.Windows.Forms.Button();
            this.listBoxLinhasCompras = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAdicionarLinhaCompras = new System.Windows.Forms.Button();
            this.txtBoxValor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalValor = new System.Windows.Forms.Label();
            this.lblNIFCliente = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.groupInserirCliente.SuspendLayout();
            this.groupListClientes.SuspendLayout();
            this.groupDetalhesCliente.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupInserirCliente
            // 
            this.groupInserirCliente.Controls.Add(this.btnAdicionarNovoCliente);
            this.groupInserirCliente.Controls.Add(this.txtBoxNIF);
            this.groupInserirCliente.Controls.Add(this.txtBoxNome);
            this.groupInserirCliente.Controls.Add(this.lblNIFNovoCliente);
            this.groupInserirCliente.Controls.Add(this.lblNomeNovoCliente);
            this.groupInserirCliente.Location = new System.Drawing.Point(12, 12);
            this.groupInserirCliente.Name = "groupInserirCliente";
            this.groupInserirCliente.Size = new System.Drawing.Size(200, 102);
            this.groupInserirCliente.TabIndex = 0;
            this.groupInserirCliente.TabStop = false;
            this.groupInserirCliente.Text = "Inserir Cliente";
            // 
            // btnAdicionarNovoCliente
            // 
            this.btnAdicionarNovoCliente.Location = new System.Drawing.Point(9, 68);
            this.btnAdicionarNovoCliente.Name = "btnAdicionarNovoCliente";
            this.btnAdicionarNovoCliente.Size = new System.Drawing.Size(185, 23);
            this.btnAdicionarNovoCliente.TabIndex = 4;
            this.btnAdicionarNovoCliente.Text = "Adicionar cliente";
            this.btnAdicionarNovoCliente.UseVisualStyleBackColor = true;
            this.btnAdicionarNovoCliente.Click += new System.EventHandler(this.btnAdicionarNovoCliente_Click);
            // 
            // txtBoxNIF
            // 
            this.txtBoxNIF.Location = new System.Drawing.Point(50, 42);
            this.txtBoxNIF.Name = "txtBoxNIF";
            this.txtBoxNIF.Size = new System.Drawing.Size(144, 20);
            this.txtBoxNIF.TabIndex = 3;
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Location = new System.Drawing.Point(50, 19);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(144, 20);
            this.txtBoxNome.TabIndex = 2;
            // 
            // lblNIFNovoCliente
            // 
            this.lblNIFNovoCliente.AutoSize = true;
            this.lblNIFNovoCliente.Location = new System.Drawing.Point(6, 45);
            this.lblNIFNovoCliente.Name = "lblNIFNovoCliente";
            this.lblNIFNovoCliente.Size = new System.Drawing.Size(27, 13);
            this.lblNIFNovoCliente.TabIndex = 1;
            this.lblNIFNovoCliente.Text = "NIF:";
            // 
            // lblNomeNovoCliente
            // 
            this.lblNomeNovoCliente.AutoSize = true;
            this.lblNomeNovoCliente.Location = new System.Drawing.Point(6, 22);
            this.lblNomeNovoCliente.Name = "lblNomeNovoCliente";
            this.lblNomeNovoCliente.Size = new System.Drawing.Size(38, 13);
            this.lblNomeNovoCliente.TabIndex = 0;
            this.lblNomeNovoCliente.Text = "Nome:";
            // 
            // groupListClientes
            // 
            this.groupListClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupListClientes.Controls.Add(this.listBoxClientes);
            this.groupListClientes.Location = new System.Drawing.Point(12, 121);
            this.groupListClientes.Name = "groupListClientes";
            this.groupListClientes.Size = new System.Drawing.Size(200, 317);
            this.groupListClientes.TabIndex = 1;
            this.groupListClientes.TabStop = false;
            this.groupListClientes.Text = "Lista de Clientes";
            // 
            // listBoxClientes
            // 
            this.listBoxClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxClientes.FormattingEnabled = true;
            this.listBoxClientes.Location = new System.Drawing.Point(7, 20);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.Size = new System.Drawing.Size(187, 290);
            this.listBoxClientes.TabIndex = 0;
            this.listBoxClientes.SelectedIndexChanged += new System.EventHandler(this.listBoxClientes_SelectedIndexChanged);
            // 
            // groupDetalhesCliente
            // 
            this.groupDetalhesCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupDetalhesCliente.Controls.Add(this.groupBox1);
            this.groupDetalhesCliente.Controls.Add(this.lblTotalValor);
            this.groupDetalhesCliente.Controls.Add(this.lblNIFCliente);
            this.groupDetalhesCliente.Controls.Add(this.lblNomeCliente);
            this.groupDetalhesCliente.Location = new System.Drawing.Point(219, 13);
            this.groupDetalhesCliente.Name = "groupDetalhesCliente";
            this.groupDetalhesCliente.Size = new System.Drawing.Size(569, 425);
            this.groupDetalhesCliente.TabIndex = 2;
            this.groupDetalhesCliente.TabStop = false;
            this.groupDetalhesCliente.Text = "Cliente";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(6, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 351);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Compras";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 191F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(543, 326);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnApagar);
            this.groupBox2.Controls.Add(this.btnCriarCompra);
            this.groupBox2.Controls.Add(this.listBoxCompras);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 320);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de compras";
            // 
            // btnApagar
            // 
            this.btnApagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApagar.Location = new System.Drawing.Point(105, 291);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(59, 23);
            this.btnApagar.TabIndex = 2;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnCriarCompra
            // 
            this.btnCriarCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCriarCompra.Location = new System.Drawing.Point(6, 291);
            this.btnCriarCompra.Name = "btnCriarCompra";
            this.btnCriarCompra.Size = new System.Drawing.Size(93, 23);
            this.btnCriarCompra.TabIndex = 1;
            this.btnCriarCompra.Text = "Criar compra";
            this.btnCriarCompra.UseVisualStyleBackColor = true;
            this.btnCriarCompra.Click += new System.EventHandler(this.btnCriarCompra_Click);
            // 
            // listBoxCompras
            // 
            this.listBoxCompras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxCompras.FormattingEnabled = true;
            this.listBoxCompras.Location = new System.Drawing.Point(6, 19);
            this.listBoxCompras.Name = "listBoxCompras";
            this.listBoxCompras.Size = new System.Drawing.Size(158, 264);
            this.listBoxCompras.TabIndex = 0;
            this.listBoxCompras.SelectedIndexChanged += new System.EventHandler(this.listBoxCompras_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnApagarLinha);
            this.groupBox3.Controls.Add(this.listBoxLinhasCompras);
            this.groupBox3.Location = new System.Drawing.Point(179, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(170, 320);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Linhas de compras";
            // 
            // btnApagarLinha
            // 
            this.btnApagarLinha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApagarLinha.Location = new System.Drawing.Point(6, 291);
            this.btnApagarLinha.Name = "btnApagarLinha";
            this.btnApagarLinha.Size = new System.Drawing.Size(158, 23);
            this.btnApagarLinha.TabIndex = 3;
            this.btnApagarLinha.Text = "Apagar";
            this.btnApagarLinha.UseVisualStyleBackColor = true;
            this.btnApagarLinha.Click += new System.EventHandler(this.btnApagarLinha_Click);
            // 
            // listBoxLinhasCompras
            // 
            this.listBoxLinhasCompras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxLinhasCompras.FormattingEnabled = true;
            this.listBoxLinhasCompras.Location = new System.Drawing.Point(6, 19);
            this.listBoxLinhasCompras.Name = "listBoxLinhasCompras";
            this.listBoxLinhasCompras.Size = new System.Drawing.Size(158, 264);
            this.listBoxLinhasCompras.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.btnAdicionarLinhaCompras);
            this.groupBox4.Controls.Add(this.txtBoxValor);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtBoxDescricao);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(355, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(185, 320);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Adicionar linha de Compra";
            // 
            // btnAdicionarLinhaCompras
            // 
            this.btnAdicionarLinhaCompras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionarLinhaCompras.Location = new System.Drawing.Point(9, 175);
            this.btnAdicionarLinhaCompras.Name = "btnAdicionarLinhaCompras";
            this.btnAdicionarLinhaCompras.Size = new System.Drawing.Size(170, 23);
            this.btnAdicionarLinhaCompras.TabIndex = 4;
            this.btnAdicionarLinhaCompras.Text = "Adicionar";
            this.btnAdicionarLinhaCompras.UseVisualStyleBackColor = true;
            this.btnAdicionarLinhaCompras.Click += new System.EventHandler(this.btnAdicionarLinhaCompras_Click);
            // 
            // txtBoxValor
            // 
            this.txtBoxValor.Location = new System.Drawing.Point(7, 134);
            this.txtBoxValor.Name = "txtBoxValor";
            this.txtBoxValor.Size = new System.Drawing.Size(172, 20);
            this.txtBoxValor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor:";
            // 
            // txtBoxDescricao
            // 
            this.txtBoxDescricao.Location = new System.Drawing.Point(7, 91);
            this.txtBoxDescricao.Name = "txtBoxDescricao";
            this.txtBoxDescricao.Size = new System.Drawing.Size(172, 20);
            this.txtBoxDescricao.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição:";
            // 
            // lblTotalValor
            // 
            this.lblTotalValor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalValor.AutoSize = true;
            this.lblTotalValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTotalValor.Location = new System.Drawing.Point(364, 21);
            this.lblTotalValor.Name = "lblTotalValor";
            this.lblTotalValor.Size = new System.Drawing.Size(66, 25);
            this.lblTotalValor.TabIndex = 2;
            this.lblTotalValor.Text = "0.00 €";
            this.lblTotalValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNIFCliente
            // 
            this.lblNIFCliente.AutoSize = true;
            this.lblNIFCliente.Location = new System.Drawing.Point(11, 50);
            this.lblNIFCliente.Name = "lblNIFCliente";
            this.lblNIFCliente.Size = new System.Drawing.Size(105, 13);
            this.lblNIFCliente.TabIndex = 1;
            this.lblNIFCliente.Text = "Selecione um cliente";
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblNomeCliente.Location = new System.Drawing.Point(6, 21);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(192, 25);
            this.lblNomeCliente.TabIndex = 0;
            this.lblNomeCliente.Text = "Selecione um cliente";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupDetalhesCliente);
            this.Controls.Add(this.groupListClientes);
            this.Controls.Add(this.groupInserirCliente);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupInserirCliente.ResumeLayout(false);
            this.groupInserirCliente.PerformLayout();
            this.groupListClientes.ResumeLayout(false);
            this.groupDetalhesCliente.ResumeLayout(false);
            this.groupDetalhesCliente.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupInserirCliente;
        private System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.Label lblNIFNovoCliente;
        private System.Windows.Forms.Label lblNomeNovoCliente;
        private System.Windows.Forms.TextBox txtBoxNIF;
        private System.Windows.Forms.Button btnAdicionarNovoCliente;
        private System.Windows.Forms.GroupBox groupListClientes;
        private System.Windows.Forms.ListBox listBoxClientes;
        private System.Windows.Forms.GroupBox groupDetalhesCliente;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label lblNIFCliente;
        private System.Windows.Forms.Label lblTotalValor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox listBoxCompras;
        private System.Windows.Forms.ListBox listBoxLinhasCompras;
        private System.Windows.Forms.TextBox txtBoxValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdicionarLinhaCompras;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnCriarCompra;
        private System.Windows.Forms.Button btnApagarLinha;
    }
}

