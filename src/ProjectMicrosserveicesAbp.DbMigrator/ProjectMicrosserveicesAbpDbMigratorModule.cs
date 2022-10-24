using ProjectMicrosserveicesAbp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace ProjectMicrosserveicesAbp.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ProjectMicrosserveicesAbpEntityFrameworkCoreModule),
    typeof(ProjectMicrosserveicesAbpApplicationContractsModule)
    )]
public class ProjectMicrosserveicesAbpDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
