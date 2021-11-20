using System.Data;


using _3C1GUSTAVOP.SIQUIEIRA16.Code.DAL;
using _3C1GUSTAVOP.SIQUIEIRA16.Code.DTO;

namespace _3C1GUSTAVOP.SIQUIEIRA16.Code.BLL
{
    class LojaBLL
    {
        //Objeto para acesso ao banco de dados
        AcessoBancoDados conexao = new AcessoBancoDados();
        string tabela = "tbl_Produtos";


        //O método de inserir recebe os dados via DTO 
        //e envia para o banco de dados através da classe AcessoBancoDados
        public void Inserir(LojaDTO Ldto)
        {
            //Antes de criar o comando aqui, teste no PhpMyAdmin ou Worckbench
            string inserir = $"insert into {tabela} values(null,'{Ldto.Nome}','{Ldto.Categoria}')";
            conexao.ExecutarComando(inserir);
        }

        public void Editar(LojaDTO Ldto)
        {
            string editar = $"update {tabela} set nome = '{Ldto.Nome}', categoria = '{Ldto.Categoria}' where id = '{Ldto.ID}';";
            conexao.ExecutarComando(editar);
        }
        public void Excluir(LojaDTO Ldto)
        {
            string excluir = $"delete from {tabela} where id = '{Ldto.ID}';";
            conexao.ExecutarComando(excluir);
        }
        public DataTable Listar()
        {
            string sql = $"select * from {tabela} order by id;";
            return conexao.ExecutarConsulta(sql);
        }
    }
}
