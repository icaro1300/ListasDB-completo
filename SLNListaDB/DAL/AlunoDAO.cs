using Dapper;
using SLNListaDB.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SLNListaDB.DAL
{
    public class AlunoDAO
    {
        SqlConnection _conexao;
        public AlunoDAO()
        {
            _conexao = ConexaoBD.getConexao();
        }

        public List<Aluno> getTodaOsAlunos()
        {
            string query = "select * from Aluno";
            _conexao.Open();

            var lista = (List<Aluno>)_conexao.Query(query);

            return lista;
        }
    }
}
