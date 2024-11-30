using Newtonsoft.Json;

namespace FluxoDeCaixa.Infrastructure.Persistence;

public class DataItem
{
    public Dictionary<string, object> Data { get; private set; }
    public string Id { get; set; }

    public DataItem()
    {
        Data = new Dictionary<string, object>();
        Id = Guid.NewGuid().ToString();
    }

    public object this[string columnName]
    {
        get => Data.ContainsKey(columnName) ? Data[columnName] : null;
        set => Data[columnName] = value;
    }

    public void LoadFromJson(string json)
    {
        var data = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);
        if (data != null)
        {
            Data = data;
            Id = data.ContainsKey("_id") ? data["_id"].ToString() : Guid.NewGuid().ToString();
        }
    }

    public string ToJson()
    {
        Data["_id"] = Id;
        return JsonConvert.SerializeObject(Data, Formatting.Indented);
    }
}