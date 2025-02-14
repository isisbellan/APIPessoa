using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pessoa
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void construirBanco_Load(object sender, EventArgs e)
        {
            Erro.setErro(false);

            DB.construirBanco();

            if (Erro.getErro())
            {
                MessageBox.Show(Erro.getMensagem(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnAdicionarPessoa_Click(object sender, EventArgs e)
        {
            FormAdicionarPessoa formAddPessoa = new FormAdicionarPessoa();
            formAddPessoa.Show();
            this.Hide();
        }

        private void btnBuscarPessoa_Click(object sender, EventArgs e)
        {
            FormBuscarPessoa formBuscaPessoa = new FormBuscarPessoa();
            formBuscaPessoa.Show();
            this.Hide();
        }

        private void btnEditarPessoa_Click(object sender, EventArgs e)
        {
            FormEditarPessoa formEditPessoa = new FormEditarPessoa();
            formEditPessoa.Show();
            this.Hide();
        }

        private void btnRemoverPessoa_Click(object sender, EventArgs e)
        {
            FormRemoverPessoa formRemovPessoa = new FormRemoverPessoa();
            formRemovPessoa.Show();
            this.Hide();
        }
    }
}
