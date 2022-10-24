using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ProjectMicrosserveicesAbp.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class ProjectMicrosserveicesAbpDbContextFactory : IDesignTimeDbContextFactory<ProjectMicrosserveicesAbpDbContext>
{
    public ProjectMicrosserveicesAbpDbContext CreateDbContext(string[] args)
    {
        ProjectMicrosserveicesAbpEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<ProjectMicrosserveicesAbpDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new ProjectMicrosserveicesAbpDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../ProjectMicrosserveicesAbp.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
