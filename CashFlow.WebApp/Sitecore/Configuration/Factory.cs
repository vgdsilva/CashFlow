using CashFlow.WebApp.Sitecore.Data;

namespace CashFlow.WebApp.Sitecore.Configuration;

public class Factory
{

    public static Database GetDatabase(string path)
    {
        return new Database();
    }
    
    
}