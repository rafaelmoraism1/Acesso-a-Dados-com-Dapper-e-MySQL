using AcessoMySQL.Repositorio;

namespace AcessoMySQL.Model
{
    public static class ListarPessoa
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Listar Pessoas");
            Console.WriteLine("----------------------------");
            List();
            Console.ReadKey();
            Program.Load();
        }

        private static void List()
        {
            var repositorio = new Repositorio<Pessoa>(Database.Connection);

            var pessoas = repositorio.Get();
            foreach (var item in pessoas)
                Console.WriteLine($"{item.Id} - {item.Nome} - {item.Email} - {item.Telefone}");
        }
    }
}