using Dapper;
using SLNListaDB.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SLNListaDB.DAL
{
    public class FuncionarioDAO
    {
        SqlConnection _conexao;
        public FuncionarioDAO()
        {
            _conexao = ConexaoBD.getConexao();
        }

        public List<FUNCIONARIO> getTodaOsFuncionarios()
        {
            string query = "select * from FUNCIONARIO";
            _conexao.Open();

            var lista = (List<FUNCIONARIO>)_conexao.Query(query);

            return lista;
        }
    }
}
