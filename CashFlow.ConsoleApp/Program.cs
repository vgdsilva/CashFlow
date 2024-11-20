using CashFlow.Business;
using CashFlow.Infrastructure;

namespace CashFlow.ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Iniciando contexto da base de dados");

        string databaseLocation = ApplicationContext.databasePath;
        
        Console.WriteLine("O contexto da base de dados será iniciado no local: {0}", databaseLocation);
        
        ApplicationContext.InitializeContext();
        
        Console.WriteLine("Existe o contexto da base de dados: {0}", Directory.Exists(databaseLocation));
        
        Console.WriteLine("Realizando os testes da base de dados.");
        
        // Exemplo de uso da biblioteca
        var database = new Database(databasePath: databaseLocation);

        Console.WriteLine("Acessando a coleção de usuários");
        var usuariosCollection = database.Collection("usuarios");

        Console.WriteLine("Criando um usuario.");
        var usuario = new Item();
        usuario["nome"] = "Vinicius Gasparello da Silva";
        
        Console.WriteLine("Usuario {0} criado com sucesso!", usuario["nome"]);
        usuariosCollection.SaveItem(usuario);

        Item fetchedUser = database.Collection("usuarios").GetItemById(usuario["id"]);
        
        Console.WriteLine($"Nome: {fetchedUser["nome"]}");
    }
}