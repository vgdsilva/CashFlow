namespace CashFlow.Infrastructure;

public class Database
{
    private readonly string _databasePath;

    public Database(string databasePath)
    {
        _databasePath = databasePath;
    }

    public void Initialize()
    {
        Directory.CreateDirectory(_databasePath); // Cria o diretório do banco de dados se não existir
    }

    public ItemCollection Collection(string collectionName)
    {
        string collectionPath = Path.Combine(_databasePath, collectionName);
        Directory.CreateDirectory(collectionPath); // Cria o diretório da coleção se não existir
        return new ItemCollection(collectionPath);
    }
}