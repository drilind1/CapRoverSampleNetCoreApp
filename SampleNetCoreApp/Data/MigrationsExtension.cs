using Microsoft.EntityFrameworkCore;

namespace SampleNetCoreApp.Data;

public static class MigrationsExtension
{
    public static void RunMigrations(this WebApplication webApplication)
    {
        using var scope = webApplication.Services.CreateAsyncScope();
        using var db = scope.ServiceProvider.GetService<ApplicationDbContext>();

        db?.Database.Migrate();
    }
}