using System.Threading.Tasks;

namespace ProjectMicrosserveicesAbp.Data;

public interface IProjectMicrosserveicesAbpDbSchemaMigrator
{
    Task MigrateAsync();
}
