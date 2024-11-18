namespace CashFlow.WebApp;

public class Program
{
    
    
    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureLogging(logging =>
            {
                logging.ClearProviders(); // Remove outros providers se necessário
                logging.AddConsole(); // Adiciona o console como destino
                logging.SetMinimumLevel(LogLevel.Information); // Define o nível mínimo de log
            })
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
    
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllersWithViews();

        var app = builder.Build();
        
        app.UseExceptionHandler("/Home/Error");

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");
        
        

        app.Run();
    }
}