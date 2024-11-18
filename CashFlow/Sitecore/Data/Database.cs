namespace CashFlow.WebApp.Sitecore.Data;

public class Database 
{
    private readonly string _databasePath;

    private readonly Dictionary<string, Dictionary<string, Item>> _itemsCollection;

    public Database(string databasePath)
    {
        _databasePath = databasePath;
        _itemsCollection = new Dictionary<string, Dictionary<string, Item>>();
    }

    public ItemCollection Collection(string collectionName)
    {
        string collectionPath = Path.Combine(_databasePath, collectionName);
        Directory.CreateDirectory(collectionPath); // Cria o diretório da coleção se não existir
        return new ItemCollection(collectionPath);
    }
    
}