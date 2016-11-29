using BancoFinal.Repositorios.Interfaces;
using System;
using System.Collections.Generic;
using BancoFinal.Entidades;
using System.Data.SqlClient;
using System.Data;

namespace BancoFinal.Repositorios
{
    public class ContaCorrenteRepositorio : Conexao, IContaCorrenteRepositorio
    {

        public void Adicionar(ContaCorrente objeto)
        {
            Escrever(Procedures.ContaCorrenteAdicionar,
                            new SqlParameter("@conSaldo", objeto.ConSaldo),
                            new SqlParameter("@cliCodigo", objeto.Cliente.CliCodigo));
        }

        public void Alterar(int codigo, ContaCorrente objetoAlterado)
        {
            Escrever(Procedures.ContaCorrenteAlterar,
                            new SqlParameter("@conCodigo", codigo),
                            new SqlParameter("@conSaldo", objetoAlterado.ConSaldo),
                            new SqlParameter("@cliCodigo", objetoAlterado.Cliente.CliCodigo));
        }

        public List<ContaCorrente> BuscarPorCliente(int cliCodigo)
        {
            List<ContaCorrente> lista = new List<ContaCorrente>();
            DataTableReader dr = Consultar(Procedures.ContaCorrenteBuscarPorCliente,
                                                      new SqlParameter("@cliCodigo", cliCodigo))
                                                      .CreateDataReader();

            while (dr.Read())
                lista.Add(new ContaCorrente(
                                new Cliente()
                                {
                                    CliCodigo = Convert.ToInt32(dr["CliCodigo"].ToString()),
                                    CliCpf = dr["CliCpf"].ToString(),
                                    CliNome = dr["CliNome"].ToString()
                                },
                                Convert.ToInt32(dr["ConCodigo"].ToString()),
                                Convert.ToDecimal(dr["ConSaldo"].ToString())
                            )
                        );
            return lista;
        }

        public ContaCorrente BuscarPorCodigo(int codigo)
        {
            DataTableReader dr = Consultar(Procedures.ContaCorrenteBuscarPorCodigo,
                                                    new SqlParameter("@conCodigo", codigo))
                                                    .CreateDataReader();

            if (dr.Read())
                return new ContaCorrente(
                                new Cliente()
                                {
                                    CliCodigo = Convert.ToInt32(dr["CliCodigo"].ToString()),
                                    CliCpf = dr["CliCpf"].ToString(),
                                    CliNome = dr["CliNome"].ToString()
                                },
                                Convert.ToInt32(dr["ConCodigo"].ToString()),
                                Convert.ToDecimal(dr["ConSaldo"].ToString())
                            );
            return null;
        }

        public void Excluir(int codigo)
        {
            Escrever(Procedures.ContaCorrenteExcluir,
                            new SqlParameter("@conCodigo", codigo));
        }

        public IEnumerable<ContaCorrente> Listar()
        {
            List<ContaCorrente> lista = new List<ContaCorrente>();
            DataTableReader dr = Consultar(Procedures.ContaCorrenteListarCompleto)
                                                    .CreateDataReader();
            while (dr.Read())
                lista.Add(new ContaCorrente(
                                new Cliente()
                                {
                                    CliCodigo = Convert.ToInt32(dr["CliCodigo"].ToString()),
                                    CliCpf = dr["CliCpf"].ToString(),
                                    CliNome = dr["CliNome"].ToString()
                                },
                                Convert.ToInt32(dr["ConCodigo"].ToString()),
                                Convert.ToDecimal(dr["ConSaldo"].ToString())
                            )
                        );
            return lista;
        }

        public DataTable ListarCompleto()
        {
            return Consultar(Procedures.ContaCorrenteListarCompleto);
        }
    }
}
