using Dapper;
using SLNListaDB.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SLNListaDB.DAL
{
    public class RecursoDAO
    {
        SqlConnection _conexao;
        public RecursoDAO()
        {
            _conexao = ConexaoBD.getConexao();
        }

        public List<Recurso> getTodaOsRecursos()
        {
            string query = "select * from Recurso";
            _conexao.Open();

            var lista = (List<Recurso>)_conexao.Query(query);

            return lista;
        }
    }
}
