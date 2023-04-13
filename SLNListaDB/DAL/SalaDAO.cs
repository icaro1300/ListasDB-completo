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
            string sql = "select * from Sala";
            var dados = (List<Sala>)_conexao.Query<Sala>(sql);

            return dados;
        }
        public void insertSala(Sala pSala)
        {
            string sql = "insert sala (SALADESCRICAO) values(@SalaDescricao)";
            var qtdInserida = _conexao.Execute(sql, pSala);
        }
    }
}
