using System;
using System.Data;
using System.Data.SqlClient;

namespace BancoFinal.Repositorios
{
    public class Conexao
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;"
                                + "Initial Catalog=BancoFinal;"
                                + "Integrated Security=True;"
                                + "Pooling=False;";

        SqlConnection connection;

        public Conexao()
        {
            connection = new SqlConnection(connectionString);
        }

        private void AtivarConexao(bool ativar)
        {
            if (ativar)
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
            }
            else
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
        }

        public DataTable Consultar(Procedures proc, params SqlParameter[] parametros)
        {
            try
            {
                DataTable dt = new DataTable();
                AtivarConexao(true);
                SqlCommand cmd = new SqlCommand(proc.ToString(), connection);
                foreach (var parametro in parametros)
                {
                    cmd.Parameters.AddWithValue(parametro.ParameterName, parametro.Value);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro inesperado ao consultar dados no banco de dados!\n\n" + ex.Message);
            }
            finally
            {
                AtivarConexao(false);
            }
        }

        public bool Escrever(Procedures proc, params SqlParameter[] parametros)
        {
            try
            {
                AtivarConexao(true);
                SqlCommand cmd = new SqlCommand(proc.ToString(), connection);
                foreach (var parametro in parametros)
                {
                    cmd.Parameters.AddWithValue(parametro.ParameterName, parametro.Value);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro inesperado ao realizar operações no banco de dados!\n\n" + ex.Message);
            }
            finally
            {
                AtivarConexao(false);
            }
        }
    }

    public enum Procedures
    {
        ClienteAdicionar,
        ClienteAlterar,
        ClienteBuscarPorCodigo,
        ClienteBuscarPorCpf,
        ClienteExcluir,
        ClienteListar,
        ContaCorrenteAdicionar,
        ContaCorrenteAlterar,
        ContaCorrenteBuscarPorCliente,
        ContaCorrenteBuscarPorCodigo,
        ContaCorrenteExcluir,
        ContaCorrenteListar,
        ContaCorrenteListarCompleto
    }
}
