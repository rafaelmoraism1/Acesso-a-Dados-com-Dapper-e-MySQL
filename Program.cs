using AcessoMySQL.Model;
using AcessoMySQL.Tela;
using MySqlConnector;

namespace AcessoMySQL
{
    internal class Program
    {
        private const string CONNECTION_STRING = @"Server=localhost,3306;Database=acessomysql;User ID=root;Password=1813";

        private static void Main(string[] args)
        {
            Database.Connection = new MySqlConnection(CONNECTION_STRING);
            Database.Connection.Open();

            Load();

            Database.Connection.Close();

            Console.ReadKey();
        }
        public static void Load()

        {
            Console.WriteLine("Escolha a Opção");
            Console.WriteLine("");
            Console.WriteLine(" 1 - Cadastrar Pessoa");
            Console.WriteLine(" 2 - Deletar Pessoa");
            Console.WriteLine(" 3 - Atualizar Pessoa");
            Console.WriteLine(" 4 - Lista de Pessoas");
            Console.WriteLine(" 5 - Encerrar Programa");
            var o = short.Parse(Console.ReadLine()!);

            switch (o)
            {
                case 1: CadastrarPessoa.Load(); break;
                case 2: DeletarPessoa.Load(); break;
                case 3: AtualizarPessoa.Load(); break;
                case 4: ListarPessoa.Load(); break;
                case 5: System.Environment.Exit(0); break;
                default: Load(); break;
            }
        }
    }
}

