namespace CashFlow.WebApp.Sitecore.Data;

public class Item
{
    private readonly Dictionary<string, object> _columns;

    public Item()
    {
        _columns = new Dictionary<string, object>();
    }

    public Object this[string columnName]
    {
        get
        {
            ArgumentException.ThrowIfNullOrEmpty(columnName);
            
            if (_columns.TryGetValue(columnName, out var columnValue))
            {
                return columnValue;
            }

            return null;
        }
        set
        {
            _columns[columnName] = value;
        }
    }

    public void Add(string columnName, object columnValue)
    {
        _columns[columnName] = columnValue;
    }

    public bool HasColumn(string columnName)
    {
        return _columns.ContainsKey(columnName);
    }
}