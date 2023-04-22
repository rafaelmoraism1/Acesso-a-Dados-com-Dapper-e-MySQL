using AcessoMySQL.Model;
using AcessoMySQL.Repositorio;

namespace AcessoMySQL.Tela
{
    public static class DeletarPessoa
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Deletar Pessoa");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Digite o nome da Pessoa que deseja Excluir: ");
            var id = Console.ReadLine()!;

            Delete(int.Parse(id));

            Console.ReadKey();
            Program.Load();
        }

        public static void Delete(int id)
        {
            try
            {
                var repositorio = new Repositorio<Pessoa>(Database.Connection);
                repositorio.Delete(id);
                Console.WriteLine("Usuário Excluído com Sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível excluir Pessoa.");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
