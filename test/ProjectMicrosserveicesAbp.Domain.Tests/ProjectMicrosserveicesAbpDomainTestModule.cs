using ProjectMicrosserveicesAbp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ProjectMicrosserveicesAbp;

[DependsOn(
    typeof(ProjectMicrosserveicesAbpEntityFrameworkCoreTestModule)
    )]
public class ProjectMicrosserveicesAbpDomainTestModule : AbpModule
{

}
