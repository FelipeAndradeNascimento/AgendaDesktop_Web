using System;
using System.Data;
using System.Data.SqlClient;

using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroBasicoDesktop.Classe_DAL
{
    internal class clsAcessoDados
    {
        #region Variaveis da Classe
        private string StrConn = "";
        #endregion

        #region Propriedades da Classe
        public SqlCommand p_parComm { get; set; }
        #endregion

        /// <summary>
        /// Inicializa o objeto sem parametro
        /// </summary>
        public clsAcessoDados()
        {

        }

        /// <summary>
        /// Instancia classe de acesso a dados informando o tipo de Ação a ser realizada
        /// </summary>
        /// <param name="parAcao">Tipos de Ações ("I"ncluir, "A"lterar, "E"xcluir, "S"elecionar)</param>
        public clsAcessoDados(string parAcao)
        {
            Conectar(parAcao);
        }

        /// <summary>
        /// Conecta e executa Query de acordo com o tipo de Ação;
        /// </summary>
        /// <param name="parAcao">Tipos de Ações ("I"ncluir, "A"lterar, "E"xcluir, "S"elecionar)</param>
        public void Conectar(string parAcao)
        {
            StrConn = ConfigurationManager.ConnectionStrings["CadastroBasicoDesktop.Properties.Settings.db_agendaConnectionString"].ConnectionString;
            SqlConnection objConn = new SqlConnection(StrConn);

            objConn.Open();

            if (objConn.State == ConnectionState.Open)
            { 
                try
                {
                    switch (parAcao)
                    {
                        case "I":
                            ExecutarQuery(objConn);
                            break;
                        case "S":
                            ExecutarSelect(objConn);
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public int ExecutarQuery(SqlConnection par_conn)
        {
            int intRetorno = -1;

            p_parComm.Connection = par_conn;
            intRetorno = p_parComm.ExecuteNonQuery();

            return intRetorno;
        }

        public void ExecutarSelect(SqlConnection par_conn)
        {

        }

        internal void fecharConexao() { }
    }
}
