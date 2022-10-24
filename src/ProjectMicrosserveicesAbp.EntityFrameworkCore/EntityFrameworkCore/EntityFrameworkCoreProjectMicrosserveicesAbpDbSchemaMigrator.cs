using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProjectMicrosserveicesAbp.Data;
using Volo.Abp.DependencyInjection;

namespace ProjectMicrosserveicesAbp.EntityFrameworkCore;

public class EntityFrameworkCoreProjectMicrosserveicesAbpDbSchemaMigrator
    : IProjectMicrosserveicesAbpDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreProjectMicrosserveicesAbpDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the ProjectMicrosserveicesAbpDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<ProjectMicrosserveicesAbpDbContext>()
            .Database
            .MigrateAsync();
    }
}
