using System.Data;

using _3C1GUSTAVOP.SIQUIEIRA16.Code.DAL;
using _3C1GUSTAVOP.SIQUIEIRA16.Code.DTO;

namespace _3C1GUSTAVOP.SIQUIEIRA16.Code.BLL
{
    class LoginBLL
    {
        AcessoBancoDados conexao = new AcessoBancoDados();
        string tabela = "tbl_login";


        public bool RealizarLogin(LoginDTO Login)
        {
            string sql = $"select * from {tabela} where email='{Login.Email}' and senha='{Login.Senha}'";
            DataTable dt = conexao.ExecutarConsulta(sql);

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
            }
    }
}
