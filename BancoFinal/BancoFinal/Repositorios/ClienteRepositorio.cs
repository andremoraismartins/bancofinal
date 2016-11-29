using BancoFinal.Repositorios.Interfaces;
using System;
using System.Collections.Generic;
using BancoFinal.Entidades;
using System.Data.SqlClient;
using System.Data;

namespace BancoFinal.Repositorios
{
    public class ClienteRepositorio : Conexao, IClienteRepositorio
    {
        public void Adicionar(Cliente objeto)
        {
            Escrever(Procedures.ClienteAdicionar,
                             new SqlParameter("@cliNome", objeto.CliNome),
                             new SqlParameter("@cliCpf", objeto.CliCpf));
        }

        public void Alterar(int codigo, Cliente objetoAlterado)
        {
            Escrever(Procedures.ClienteAlterar,
                        new SqlParameter("@cliCodigo", codigo),
                        new SqlParameter("@cliNome", objetoAlterado.CliNome),
                        new SqlParameter("@cliCpf", objetoAlterado.CliCpf));
        }

        public Cliente BuscarPorCpf(string cliCpf)
        {
            DataTableReader dr = Consultar(Procedures.ClienteBuscarPorCpf,
                                                      new SqlParameter("@cliCpf", cliCpf))
                                                      .CreateDataReader();
            if (dr.Read())
                return new Cliente()
                {
                    CliCodigo = Convert.ToInt32(dr["CliCodigo"].ToString()),
                    CliCpf = dr["CliCpf"].ToString(),
                    CliNome = dr["CliNome"].ToString()
                };

            return null;
        }

        public Cliente BuscarPorCodigo(int codigo)
        {
            DataTableReader dr = Consultar(Procedures.ClienteBuscarPorCodigo,
                                                    new SqlParameter("@cliCodigo", codigo))
                                                    .CreateDataReader();
            if (dr.Read())
                return new Cliente()
                {
                    CliCodigo = Convert.ToInt32(dr["CliCodigo"].ToString()),
                    CliCpf = dr["CliCpf"].ToString(),
                    CliNome = dr["CliNome"].ToString()
                };

            return null;
        }

        public void Excluir(int codigo)
        {
            Escrever(Procedures.ClienteExcluir,
                            new SqlParameter("@cliCodigo", codigo));
        }

        public IEnumerable<Cliente> Listar()
        {
            List<Cliente> lista = new List<Cliente>();
            DataTableReader dr = Consultar(Procedures.ClienteListar)
                                                    .CreateDataReader();
            while (dr.Read())
                lista.Add(new Cliente()
                {
                    CliCodigo = Convert.ToInt32(dr["CliCodigo"].ToString()),
                    CliCpf = dr["CliCpf"].ToString(),
                    CliNome = dr["CliNome"].ToString()
                });

            return lista;
        }
    }
}
