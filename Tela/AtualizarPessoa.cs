using AcessoMySQL.Model;
using AcessoMySQL.Repositorio;

namespace AcessoMySQL.Tela
{
    public static class AtualizarPessoa
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atualizar Pessoa");
            Console.WriteLine("----------------------------");

            Console.WriteLine("Id: ");
            var id = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Nome: ");
            var nome = Console.ReadLine();
            Console.WriteLine("Email: ");
            var email = Console.ReadLine();
            Console.WriteLine("Telefone: ");
            var telefone = Console.ReadLine();

            Update(new Pessoa { Id = id, Nome = nome, Email = email, Telefone = telefone });

            Console.ReadKey();
            Program.Load();
        }

        public static void Update(Pessoa pessoa)
        {
            try
            {
                var repositorio = new Repositorio<Pessoa>(Database.Connection);
                repositorio.Update(pessoa);
                Console.WriteLine("Usuário atualizado com Sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível atualizar Pessoa.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
