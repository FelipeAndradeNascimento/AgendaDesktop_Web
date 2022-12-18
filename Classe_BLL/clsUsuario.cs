using System;
using System.Data;
using System.Data.SqlClient;
using CadastroBasicoDesktop.Classe_DAL;
using System.Threading.Tasks;

namespace CadastroBasicoDesktop.Classe_BLL
{
    public class clsUsuario
    {
        public void fnInserirUsuario(string parNome, string parEmail, string parCpf, string parTelefone, int parIdEndereco)
        {
            string str_sql = "INSERT INTO tbContatos (Nome,Email,Cpf,Telefone,IdEndereco) VALUES (@nome, @email, @cpf, @telefone, @idEndereco)";
            
            SqlCommand obj_cmd = new SqlCommand(str_sql);
            obj_cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = parNome;
            obj_cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = parEmail;
            obj_cmd.Parameters.Add("@cpf", SqlDbType.VarChar).Value = parCpf;
            obj_cmd.Parameters.Add("@telefone", SqlDbType.VarChar).Value = parTelefone;
            obj_cmd.Parameters.Add("@idEndereco", SqlDbType.Int).Value = parIdEndereco;

            try
            {
                clsAcessoDados objExecutarQuery = new clsAcessoDados();
                objExecutarQuery.p_parComm = obj_cmd;
                objExecutarQuery.Conectar("I");
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void fnEditarUsuario(int parIdContato, string parNome, string parEmail, string parCpf, string parTelefone, int parIdEndereco)
        {
            string str_sql = "UPDATE tbContatos " +
                "SET Nome = @nome, Email = @email" +
                ",Cpf = @cpf ,Telefone = @telefone, IdEndereco = @idEndereco" +
                "WHERE idContato = @idContato";

            SqlConnection str_con = new SqlConnection("Data Source=localhost;Initial Catalog=db_agenda;User ID=sa;Password=123456");
            SqlCommand obj_cmd = new SqlCommand(str_sql, str_con);

            obj_cmd.Parameters.Add("@idContato", SqlDbType.Int).Value = parIdContato;
            obj_cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = parNome;
            obj_cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = parEmail;
            obj_cmd.Parameters.Add("@cpf", SqlDbType.VarChar).Value = parCpf;
            obj_cmd.Parameters.Add("@telefone", SqlDbType.VarChar).Value = parTelefone;
            obj_cmd.Parameters.Add("@idEndereco", SqlDbType.Int).Value = parIdEndereco;

            try
            {
                str_con.Open();
                obj_cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;

            }
        }
    }
}
