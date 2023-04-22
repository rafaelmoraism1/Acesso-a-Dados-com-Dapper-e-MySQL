using AcessoMySQL;
using AcessoMySQL.Model;
using AcessoMySQL.Repositorio;

public static class CadastrarPessoa
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Novo Usuário");
        Console.WriteLine("----------------------------");
        Console.WriteLine("Nome: ");
        var nome = Console.ReadLine();
        Console.WriteLine("Email: ");
        var email = Console.ReadLine();
        Console.WriteLine("Telefone: ");
        var telefone = Console.ReadLine();

        Create(new Pessoa { Nome = nome, Email = email, Telefone = telefone });

        Console.ReadKey();
        Program.Load();
    }

    public static void Create(Pessoa pessoa)
    {
        try
        {
            var repositorio = new Repositorio<Pessoa>(Database.Connection);
            repositorio.Create(pessoa);
            Console.WriteLine("Usuário Cadastrado com Sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Não foi possível cadastrar Pessoa.");
            Console.WriteLine(ex.Message);
        }
    }
}