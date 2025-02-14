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
    public partial class FormRemoverPessoa : Form
    {
        Pessoa pessoa = new Pessoa();

        public FormRemoverPessoa()
        {
            InitializeComponent();
        }
        
        private void btnDeletePessoa_Click(object sender, EventArgs e)
        {
            string id = tbId.Text;

            if (String.IsNullOrEmpty(id))
            {
                MessageBox.Show("Id é de preenchimento obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PessoaBLL.removePessoa(id);

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMensagem(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show($"Pessoa removida com suceso", "Pessoa removida", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
