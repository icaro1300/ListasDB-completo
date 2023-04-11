using Dapper;
using SLNListaDB.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SLNListaDB.DAL
{
    public class CursoDAO
    {
        SqlConnection _conexao;
        public CursoDAO()
        {
            _conexao = ConexaoBD.getConexao();
        }

        public List<Curso> getTodaOsCursos()
        {
            string query = "select * from Curso";
            _conexao.Open();

            var lista = (List<Curso>)_conexao.Query(query);

            return lista;
        }
    }
}
