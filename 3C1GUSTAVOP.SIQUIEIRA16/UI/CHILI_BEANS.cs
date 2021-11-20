using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3C1GUSTAVOP.SIQUIEIRA16.Code.BLL;
using _3C1GUSTAVOP.SIQUIEIRA16.Code.DTO;
namespace _3C1GUSTAVOP.SIQUIEIRA16
{
    public partial class frm_Registro : Form
    {

        LojaBLL Lbll = new LojaBLL();
        LojaDTO Ldto = new LojaDTO();

        public frm_Registro()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvLoja.DataSource = Lbll.Listar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Ldto.Nome = txtNome.Text;
            Ldto.Categoria = txtCat.Text;
            Lbll.Inserir(Ldto);
            MessageBox.Show("Cadastro realizado!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtCat.Clear();
            txtId.Clear();
            txtNome.Clear();
            dgvLoja.DataSource = Lbll.Listar();
        }

        private void dgvLoja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvLoja.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dgvLoja.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCat.Text = dgvLoja.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Ldto.ID = int.Parse(txtId.Text);
            Ldto.Nome = txtNome.Text;
            Ldto.Categoria = txtCat.Text;
            Lbll.Editar(Ldto);
            MessageBox.Show("Cadastro editado com sucesso!", "Edição", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtCat.Clear();
            txtId.Clear();
            txtNome.Clear();
            dgvLoja.DataSource = Lbll.Listar();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            Ldto.ID = int.Parse( txtId.Text);
            Lbll.Excluir(Ldto);
            MessageBox.Show("Cadastro deletado com sucesso!", "Edição", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtCat.Clear();
            txtId.Clear();
            txtNome.Clear();
            dgvLoja.DataSource = Lbll.Listar();
        }
    }
}
