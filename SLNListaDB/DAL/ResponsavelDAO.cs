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
            string sql = "SELECT * FROM Responsavel";


            var dados = (List<Responsavel>)_conexao.Query<Responsavel>(sql);

            return dados;
        }
    }
}
