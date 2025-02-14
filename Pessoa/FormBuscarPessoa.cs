using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pessoa
{
    public partial class FormBuscarPessoa : Form
    {
        Pessoa pessoa = new Pessoa();

        public FormBuscarPessoa()
        {
            InitializeComponent();
        }

        private void btnReadPessoa_Click(object sender, EventArgs e)
        {
            string id = tbId.Text;

            if (String.IsNullOrEmpty(id))
            {
                MessageBox.Show("Id é de preenchimento obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var pessoaDb = PessoaBLL.readPessoa(id);

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMensagem(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            tbNome.Text = pessoaDb.Nome;
            mtbTelefone.Text = pessoaDb.Telefone;
            tbEmail.Text  = pessoaDb.Email;
            mtbCEP.Text   = pessoaDb.CEP;
            tbEstado.Text = pessoaDb.Estado;
            tbCidade.Text = pessoaDb.Cidade;
            tbBairro.Text = pessoaDb.Bairro;
            tbRua.Text    = pessoaDb.Rua;
            tbNumeroRua.Text   = pessoaDb.NumeroRua;
            tbComplemento.Text = pessoaDb.Complemento;
        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            tbId.Clear();
            tbNome.Clear();
            mtbTelefone.Clear();
            tbEmail.Clear();
            mtbCEP.Clear();
            tbEstado.Clear();
            tbCidade.Clear();
            tbBairro.Clear();
            tbRua.Clear();
            tbNumeroRua.Clear();
            tbComplemento.Clear();
        }

        private void btnVoltarAoMenu_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
            this.Hide();
        }

        private void FormBuscarPessoa_Load(object sender, EventArgs e)
        {

        }
    }
}
