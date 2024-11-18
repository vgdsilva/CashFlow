using CashFlow.WebApp.Sitecore.Data;

namespace CashFlow.WebApp.Sitecore.Configuration;

public class Factory
{

    public static Database GetDatabase(string name)
    {
        return new Database(name);
    }

    public static void InstanseNewDatabase(string name)
    {
        var dbPath = Path.Combine(AppContext.BaseDirectory, $"{name}.json");

        if (!File.Exists(dbPath))
        {
            
        }
    }
}