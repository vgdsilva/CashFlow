namespace CashFlow.Infrastructure;

public class ItemCollection
{
    private readonly string _collectionPath;

    public ItemCollection(string collectionPath)
    {
        _collectionPath = collectionPath;
    }

    public List<Item> GetAllItems()
    {
        var items = new List<Item>();

        foreach (var filePath in Directory.GetFiles(_collectionPath, "*.json"))
        {
            var json = File.ReadAllText(filePath);
            var item = new Item();
            item.LoadFromJson(json);
            items.Add(item);
        }

        return items;
    }

    public Item GetItemById(string id)
    {
        string filePath = Path.Combine(_collectionPath, $"{id}.json");
        if (File.Exists(filePath))
        {
            var json = File.ReadAllText(filePath);
            var item = new Item();
            item.LoadFromJson(json);
            return item;
        }

        return null; // Retorna null se o item não existir
    }
    
    public Item GetItemById(object id)
    {
        string filePath = Path.Combine(_collectionPath, $"{id}.json");
        if (File.Exists(filePath))
        {
            var json = File.ReadAllText(filePath);
            var item = new Item();
            item.LoadFromJson(json);
            return item;
        }

        return null; // Retorna null se o item não existir
    }

    public void SaveItem(Item item)
    {
        string filePath = Path.Combine(_collectionPath, $"{item.Id}.json");
        File.WriteAllText(filePath, item.ToJson());
    }

    public void DeleteItem(string id)
    {
        string filePath = Path.Combine(_collectionPath, $"{id}.json");
        if (File.Exists(filePath))
        {
            File.Delete(filePath);
        }
    }
}