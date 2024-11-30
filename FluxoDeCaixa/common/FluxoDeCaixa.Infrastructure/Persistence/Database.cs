namespace FluxoDeCaixa.Infrastructure.Persistence;

public class Database
{
    private readonly string _databasePath;

    public Database(string databasePath)
    {
        _databasePath = databasePath;
    }

    public static void InstanseNewDatabase(string databasePath)
    {
        var database = Path.Combine(databasePath, "Fluxo de caixa");
        
        if (!Directory.Exists(database))
        {
            Directory.CreateDirectory(database);
        }
    }

    public DataItemCollection Collection(string collectionName)
    {
        string collectionPath = Path.Combine(_databasePath, "Fluxo de caixa", collectionName);

        if (!Directory.Exists(collectionPath))
        {
            Directory.CreateDirectory(collectionPath);
        }
        
        return new DataItemCollection(collectionPath);
    }
}