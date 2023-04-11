using Dapper;
using SLNListaDB.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SLNListaDB.DAL
{
    public class SalaDAO
    {
        SqlConnection _conexao;
        public SalaDAO()
        {
            _conexao = ConexaoBD.getConexao();
        }

        public List<Sala> getTodaAsSalas()
        {
            string query = "select * from Sala";
            _conexao.Open();

            var lista = (List<Sala>)_conexao.Query(query);

            return lista;
        }
    }
}
