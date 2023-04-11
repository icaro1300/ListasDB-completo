using Dapper;
using SLNListaDB.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SLNListaDB.DAL
{
    public class SerieDAO
    {
        SqlConnection _conexao;
        public SerieDAO()
        {
            _conexao = ConexaoBD.getConexao();
        }

        public List<Serie> getTodaAsSeries()
        {
            string query = "select * from Serie";
            _conexao.Open();

            var lista = (List<Serie>)_conexao.Query(query);

            return lista;
        }
    }
}
