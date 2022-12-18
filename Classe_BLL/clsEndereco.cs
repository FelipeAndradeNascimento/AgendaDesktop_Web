using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace CadastroBasicoDesktop.Classe_BLL
{
    public class clsEndereco
    {
        public void fnInserirEndereco(string parRua, string parBairro, string parCidade, string parUf, int parCep)
        {
            string str_sql = "INSERT INTO tbEndereco (Rua,Bairro,Cidade,Uf,Cep) VALUES (@Rua, @Bairro, @Cidade, @Uf, @Cep)";

            SqlConnection str_con = new SqlConnection("Data Source=localhost;Initial Catalog=db_agenda;User ID=sa;Password=123456");
            SqlCommand obj_cmd = new SqlCommand(str_sql, str_con);

            obj_cmd.Parameters.Add("@Rua", SqlDbType.VarChar).Value = parRua;
            obj_cmd.Parameters.Add("@Bairro", SqlDbType.VarChar).Value = parBairro;
            obj_cmd.Parameters.Add("@Cidade", SqlDbType.VarChar).Value = parCidade;
            obj_cmd.Parameters.Add("@Uf", SqlDbType.VarChar).Value = parUf;
            obj_cmd.Parameters.Add("@Cep", SqlDbType.Int).Value = parCep;

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

        public void fnEditarUsuario(int parIdEndereco, string parRua, string parBairro, string parCidade, string parUf, int parCep)
        {
            string str_sql = "UPDATE tbEndereco " +
                "SET Rua = @Rua, Bairro = @Bairro" +
                ",Cidade = @Cidade ,Uf = @Uf, Cep = @Cep" +
                "WHERE IdEndereco = @IdEndereco";

            SqlConnection str_con = new SqlConnection("Data Source=localhost;Initial Catalog=db_agenda;User ID=sa;Password=123456");
            SqlCommand obj_cmd = new SqlCommand(str_sql, str_con);

            obj_cmd.Parameters.Add("@IdEndereco", SqlDbType.Int).Value = parIdEndereco;
            obj_cmd.Parameters.Add("@Rua", SqlDbType.VarChar).Value = parRua;
            obj_cmd.Parameters.Add("@Bairro", SqlDbType.VarChar).Value = parBairro;
            obj_cmd.Parameters.Add("@Cidade", SqlDbType.VarChar).Value = parCidade;
            obj_cmd.Parameters.Add("@Uf", SqlDbType.VarChar).Value = parUf;
            obj_cmd.Parameters.Add("@Cep", SqlDbType.Int).Value = parCep;

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
