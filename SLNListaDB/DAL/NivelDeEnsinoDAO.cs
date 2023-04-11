using Dapper;
using SLNListaDB.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SLNListaDB.DAL
{
    public class NivelDeEnsinoDAO
    {
        SqlConnection _conexao;
        public NivelDeEnsinoDAO()
        {
            _conexao = ConexaoBD.getConexao();
        }

        public List<NivelDeEnsino> getTodaOsNivelDeEnsinos()
        {
            string query = "select * from NivelDeEnsino";
            _conexao.Open();

            var lista = (List<NivelDeEnsino>)_conexao.Query(query);

            return lista;
        }
    }
}
