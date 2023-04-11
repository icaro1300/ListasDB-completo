using Dapper;
using SLNListaDB.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SLNListaDB.DAL
{
    public class CategoriaDAO
    {
        SqlConnection _conexao;
        public CategoriaDAO()
        {
            _conexao = ConexaoBD.getConexao();
        }

        public List<Categoria> getTodaOsCursos()
        {
            string query = "select * from Categoria";
            _conexao.Open();

            var lista = (List<Categoria>)_conexao.Query(query);

            return lista;
        }
    }
}
