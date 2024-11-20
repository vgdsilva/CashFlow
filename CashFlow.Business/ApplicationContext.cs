using CashFlow.Infrastructure;

namespace CashFlow.Business;

public class ApplicationContext
{
    public static string databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "FluxoDeCaixa");

    public static void InitializeContext()
    {
        new Database(databasePath).Initialize();
    }
}