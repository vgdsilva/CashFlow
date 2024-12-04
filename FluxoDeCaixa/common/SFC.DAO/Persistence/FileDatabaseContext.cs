namespace SFC.DAO;

public class FileDatabaseContext
{

    public string DatabasePath { get; set; }
    
    
    
    public FileDatabaseContext(string databasePath, string datbaseName)
    {
        DatabasePath = Path.Combine(databasePath, datbaseName, "data");
    }
    
    
    public void Instanciate()
    {
        OnDatabaseCreated();
    }

    public virtual void OnDatabaseCreated()
    {
            
    }
}