using Volo.Abp.Modularity;

namespace ProjectMicrosserveicesAbp;

[DependsOn(
    typeof(ProjectMicrosserveicesAbpApplicationModule),
    typeof(ProjectMicrosserveicesAbpDomainTestModule)
    )]
public class ProjectMicrosserveicesAbpApplicationTestModule : AbpModule
{

}
