using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace api.Models.Login
{
    public class Login
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
        public bool Ativo { get; set; }
        #region Filtro
        public class Filtro
        {
            public string Name { get; set; }
            public bool Ativo { get; set; }
        }
        #endregion

        #region Crud
        public static List<Login> Buscar(Filtro filtro, SqlConnection conn)
        {
            throw new NotImplementedException();
        }

        private bool Salvar(SqlConnection conn)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Serviço
        public bool InserirAtualizar(SqlConnection conn)
        {
            return Salvar(conn);
        }
        #endregion
    }
}