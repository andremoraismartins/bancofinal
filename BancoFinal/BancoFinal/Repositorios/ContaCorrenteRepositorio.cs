using BancoFinal.Repositorios.Interfaces;
using System;
using System.Collections.Generic;
using BancoFinal.Classes;
using System.Data.SqlClient;
using System.Data;

namespace BancoFinal.Repositorios
{
    public class ContaCorrenteRepositorio : IContaCorrenteRepositorio
    {
        Conexao conexao = new Conexao();

        public void Adicionar(ContaCorrente objeto)
        {
            conexao.Escrever(Procedures.ContaCorrenteAdicionar,
                            new SqlParameter("@conSaldo", objeto.ConSaldo),
                            new SqlParameter("@cliCodigo", objeto.Cliente.CliCodigo));
        }

        public void Alterar(int codigo, ContaCorrente objetoAlterado)
        {
            conexao.Escrever(Procedures.ContaCorrenteAlterar,
                            new SqlParameter("@conCodigo", codigo),
                            new SqlParameter("@conSaldo", objetoAlterado.ConSaldo),
                            new SqlParameter("@cliCodigo", objetoAlterado.Cliente.CliCodigo));
        }

        public List<ContaCorrente> BuscarPorCliente(int cliCodigo)
        {
            List<ContaCorrente> lista = new List<ContaCorrente>();
            DataTableReader dr = conexao.Consultar(Procedures.ContaCorrenteBuscarPorCliente,
                                                      new SqlParameter("@cliCodigo", cliCodigo))
                                                      .CreateDataReader();

            while (dr.Read())
            {
                ClienteRepositorio clienteRepo = new ClienteRepositorio();
                Cliente cliente = clienteRepo.BuscarPorCodigo(Convert.ToInt32(dr["CliCodigo"].ToString()));
                if (cliente == null)
                    throw new Exception("Não foi possível encontrar o cliente da conta corrente selecionada!");

                lista.Add(new ContaCorrente(cliente, Convert.ToInt32(dr["ConCodigo"].ToString()), Convert.ToDecimal(dr["ConSaldo"].ToString())));
            }
            return lista;
        }

        public ContaCorrente BuscarPorCodigo(int codigo)
        {
            DataTableReader dr = conexao.Consultar(Procedures.ContaCorrenteBuscarPorCodigo,
                                                    new SqlParameter("@conCodigo", codigo))
                                                    .CreateDataReader();

            if (dr.Read())
            {
                ClienteRepositorio clienteRepo = new ClienteRepositorio();
                Cliente cliente = clienteRepo.BuscarPorCodigo(Convert.ToInt32(dr["CliCodigo"].ToString()));
                if (cliente == null)
                    throw new Exception("Não foi possível encontrar o cliente da conta corrente selecionada!");

                return new ContaCorrente(cliente, Convert.ToInt32(dr["ConCodigo"].ToString()), Convert.ToDecimal(dr["ConSaldo"].ToString()));
            }
            return null;
        }

        public void Excluir(int codigo)
        {
            conexao.Escrever(Procedures.ContaCorrenteExcluir,
                            new SqlParameter("@conCodigo", codigo));
        }

        public IEnumerable<ContaCorrente> Listar()
        {
            List<ContaCorrente> lista = new List<ContaCorrente>();
            DataTableReader dr = conexao.Consultar(Procedures.ContaCorrenteListar)
                                                    .CreateDataReader();
            while (dr.Read())
            {
                ClienteRepositorio clienteRepo = new ClienteRepositorio();
                Cliente cliente = clienteRepo.BuscarPorCodigo(Convert.ToInt32(dr["CliCodigo"].ToString()));
                if (cliente == null)
                    throw new Exception("Não foi possível encontrar o cliente da conta corrente selecionada!");

                lista.Add(new ContaCorrente(cliente, Convert.ToInt32(dr["ConCodigo"].ToString()), Convert.ToDecimal(dr["ConSaldo"].ToString())));
            }
            return lista;
        }

        public DataTable ListarCompleto()
        {
            return conexao.Consultar(Procedures.ContaCorrenteListarCompleto);
        }
    }
}
