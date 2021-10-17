using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace api.Models
{
    public enum Banco
    {
        Itau = 1,
        Bradesco = 2
    }
    public class ContaBancaria
    {
        public int ID { get; set; }
        public Banco Banco { get; set; }
        public string Conta { get; set; }
        public string Agencia { get; set; }

        #region Filtro 
        public class Filtro
        {
            public int? ID { get; set; }
            public Banco? Banco { get; set; }
            public string Conta { get; set; }
            public string Agencia { get; set; }
        }
        #endregion

        #region Crud
        public static List<ContaBancaria> Buscar(Filtro filtro, SqlConnection conn)
        {
            throw new NotImplementedException();
        }

        private bool Salvar(SqlConnection conn)
        {
            throw new NotImplementedException();
        }

        public bool InserirAtualizar(SqlConnection conn)
        {
            return Salvar(conn);
        }
        #endregion
    }
}