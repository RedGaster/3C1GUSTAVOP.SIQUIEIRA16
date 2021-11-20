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

namespace _3C1GUSTAVOP.SIQUIEIRA16.UI
{
    public partial class LOGIN : Form
    {
        LoginBLL loginBLL = new LoginBLL();
        LoginDTO loginDTO = new LoginDTO();
        public LOGIN()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            loginDTO.Email = txtEmail.Text;
            loginDTO.Senha = txtSenha.Text;

            if (loginBLL.RealizarLogin(loginDTO) == true)
            {
                frm_Registro Frm_Registro = new frm_Registro();
                Frm_Registro.ShowDialog();
            }
            else
            {
                MessageBox.Show("Verifique o login!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
