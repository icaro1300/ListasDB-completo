using Dapper;
using SLNListaDB.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SLNListaDB.DAL
{
    public class DepartamentoDAO
    {
        SqlConnection _conexao;
        public DepartamentoDAO()
        {
            _conexao = ConexaoBD.getConexao();
        }

        public List<Departamento> getTodaOsDepartamentos()
        {
            string query = "select * from Departamento";
            _conexao.Open();

            var lista = (List<Departamento>)_conexao.Query(query);

            return lista;
        }
    }
}
