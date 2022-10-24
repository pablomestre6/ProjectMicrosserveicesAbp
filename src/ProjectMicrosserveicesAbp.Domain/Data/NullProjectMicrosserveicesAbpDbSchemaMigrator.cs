using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ProjectMicrosserveicesAbp.Data;

/* This is used if database provider does't define
 * IProjectMicrosserveicesAbpDbSchemaMigrator implementation.
 */
public class NullProjectMicrosserveicesAbpDbSchemaMigrator : IProjectMicrosserveicesAbpDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
