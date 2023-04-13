using Dapper;
using SLNListaDB.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SLNListaDB.DAL
{
    public class ResponsavelDAO
    {
        SqlConnection _conexao;
        public ResponsavelDAO()
        {
            _conexao = ConexaoBD.getConexao();
        }

        public List<Responsavel> getTodaOsResponsavel()
        {
            string sql = "select * from Responsavel";

            var dados = (List<Responsavel>)_conexao.Query<Responsavel>(sql);

            return dados;
        }
        public void InsertResponsavel(Responsavel pResponsavel)
        {
            string sql = "insert Responsavel (ResponsavelNome) values(@RespNome)";
            int qtdInserida = _conexao.Execute(sql, pResponsavel);
        }
        public void insertResponsavel(Responsavel pResponsavel)
        {
            string sql = "insert Responsavel (ResponsavelIdade) values(@RespIdade)";
            int qtdInserida = _conexao.Execute(sql, pResponsavel);
        }
    }
}
