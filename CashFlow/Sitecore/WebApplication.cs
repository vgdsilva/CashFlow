namespace CashFlow.WebApp.Sitecore;

public class WebApplication
{
    public static string databasePath = Path.Combine(Environment.SpecialFolder.Desktop.ToString(), "Fluxo  de Caixa", "database");
    
    public static void Inicializar()
    {
        Directory.CreateDirectory(databasePath);
        
    }
}