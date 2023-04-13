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

        public List<Aluno> getTodoOsAlunos()
        {
            string sql = "select * from Aluno";
            var dados = (List<Aluno>)_conexao.Query(sql);

            return dados;
        }
        public void InsertAluno(Aluno pAluno)
        {
            string sql = "insert Aluno (AlunoNome) values(@AlunoNome)";
            int qtdInserida = _conexao.Execute(sql, pAluno);
        }
        public void insertAluno(Aluno pAluno)
        {
            string sql = "insert Aluno (AlunoSobrenome) values(@AlunoSobrenome)";
            int qtdInserida = _conexao.Execute(sql, pAluno);
        }
    }
}
