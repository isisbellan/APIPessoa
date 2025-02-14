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
    public partial class FormAdicionarPessoa : Form
    {
        Pessoa pessoa = new Pessoa();

        public FormAdicionarPessoa()
        {
            InitializeComponent();
        }

        private void btnCreatePessoa_Click(object sender, EventArgs e)
        {
            pessoa.Nome = tbNome.Text;
            pessoa.Telefone = mtbTelefone.Text;
            pessoa.Email  = tbEmail.Text;
            pessoa.CEP    = mtbCEP.Text;
            pessoa.Estado = tbEstado.Text;
            pessoa.Cidade = tbCidade.Text;
            pessoa.Bairro = tbBairro.Text;
            pessoa.Rua    = tbRua.Text;
            pessoa.NumeroRua   = tbNumeroRua.Text;
            pessoa.Complemento = tbComplemento.Text;

            PessoaBLL.validarDados(pessoa);

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMensagem(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idPessoa = PessoaBLL.createPessoa(pessoa);

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMensagem(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show($"Pessoa nº{idPessoa} adicionada", "Pessoa adicionada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }     

        private async void mtbCEP_TextChanged(object sender, EventArgs e)
        {
            string cep = mtbCEP.Text.Replace("-", "").Trim();

            if (cep.Length == 8)
            {
                var endereco = await API.BuscarInfoMoradiaAsync(cep);

                if (Erro.getErro())
                {
                    MessageBox.Show(Erro.getMensagem(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                tbRua.Text    = endereco["logradouro"].ToString();
                tbBairro.Text = endereco["bairro"].ToString();
                tbCidade.Text = endereco["localidade"].ToString();
                tbEstado.Text = endereco["uf"].ToString();
            }
        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
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

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
