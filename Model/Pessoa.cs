
using Dapper.Contrib.Extensions;

namespace AcessoMySQL.Model
{
    [Table("pessoa")]
    public class Pessoa
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }

    }
}