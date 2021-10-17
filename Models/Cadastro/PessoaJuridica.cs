using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace api.Models.Cadastro.PessoaJuridica
{
    public enum TipoDoc
    {
        RG = 1,
        CNH = 2,
        PassaPorte = 3,
        CertidaoNascimento = 4,
        CarteiraTrabalho = 5,
        RNE = 6
    }
    public class PessoaJuridica
    {
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string CNPJ { get; set; }
        public TipoDoc TipoDocumento { get; set; }
        public decimal RendaMensal { get; set; }
        public decimal Patrimonio { get; set; }
        public decimal? OutrosRendimentos { get; set; }
        public string website { get; set; }
        public List<ContaBancaria> ContasBancarias { get; set; }
        public string NIF { get; set; }
        public List<Socio> ParticipacaoSocietaria { get; set; }
        public string CNAE { get; set; }
        public string AtividadePrincipal { get; set; }
        public string IE { get; set; }

        #region Filtro 
        public class Filtro
        {
            public string Nome { get; set; }
            public string CPFCNPJ { get; set; }
            public string IE { get; set; }
        }
        #endregion

        #region Crud
        public static List<PessoaJuridica> Buscar(Filtro filtro, SqlConnection conn)
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
    public class Socio
    {
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string CNPJ { get; set; }
        public List<ContaBancaria> ContasBancarias { get; set; }
        public string CPF { get; set; }
        public TipoDoc TipoDocumento { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime? DataExpiracao { get; set; }
        public List<Contato> Contatos { get; set; }
        public Endereco Endereco { get; set; }
        public decimal CaptalSocial { get; set; }
        public decimal PorcentagemCaptal { get; set; }

        #region Filtro 
        public class Filtro
        {
            public string Nome { get; set; }
            public string CPFCNPJ { get; set; }
        }
        #endregion

        #region CRUD
        public static List<Socio> Buscar(Filtro filtro, SqlConnection conn)
        {
            throw new NotFiniteNumberException();
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
    public class Contato
    {
        public enum Tipo
        {
            Email = 1,
            Telefone = 2
        }

        public int ID { get; set; }
        public Tipo TipoContato { get; set; }
        public string NomeContato { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
    }
    public class Endereco
    {
        public int ID { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string CEP { get; set; }
    }
}